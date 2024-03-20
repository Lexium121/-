using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vigener
{
    public partial class Analyz : Form
    {
        public Analyz()
        {
            InitializeComponent();
        }

        private static Analyz analyzForm;

        public static Analyz AnalyzForm
        {
            get
            {
                if (analyzForm == null || analyzForm.IsDisposed)
                    analyzForm = new Analyz();
                return analyzForm;
            }
        }

        public void ShowForm()
        {
            Activate();
            Show();            
        }

        string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int len_alpha = 33;
        int[] mostUse = { 15, 5, 0, 9, 14, 19, 18, 17 }; //О, Е, А, И, Н, Т, С, Р

        private int NOD(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }

        private string cleanText(string text)
        {
            text = text.ToLower();
            string cText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (alpha.Contains(text[i]))
                {
                    cText += text[i];
                }
            }
            return cText;
        }

        private int countX(List<int> list, int x) 
        { 
            int c  = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == x) { c++; }
            }
            return c; 
        }

        private int testKasiski(string text)
        {
            List<int> l = new List<int>();
            int t = 3; // выделяем фрагменты по 3 (можно изменить)
            for (int i = 0; i < text.Length - t; i++)
            {
                string sub = text.Substring(i, t); //выделяем подстроку из t элементов
                if (text.IndexOf(sub, i + 1) != -1) //если подстрока найдена
                {
                    //находим разницу между ближайшей найденной комбинацией из трех символов
                    //и текущей
                    l.Add(text.IndexOf(sub, i + 1) - i);
                }
                if (l.Count > 100)
                    break;
            }
            if (l.Count == 0)
                return -1; // не найдено ни одной повторяющейся комбинации

            List<int> nod = new List<int>(); // создаем спиоск nod
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                    nod.Add(NOD(l[i], l[j])); //находим наибольший общий делитель
            }
            int max_count = 0;
            int result_nod = 0;
            for (int i = 0; i < nod.Count; i++)
                if (countX(nod, nod[i]) > max_count)
                {
                    max_count = countX(nod, nod[i]);
                    result_nod = nod[i];
                }
            return result_nod; // это и есть предполагаемая длина ключа
        }

        private float[] chastota(string text)
        {
            float[] chas = new float[alpha.Length];
            for (int i = 0; i < chas.Length; i++)
            {
                //находим частоту символа как количество его в тексте, деленное на длину текста
                chas[i] = (text.Count(ch => ch == alpha[i]) * 1.0f) / text.Length;
            }
            return chas;
        }

        private int index(float[] a, float x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                    return i; //возвращаем искомый индекс
            }
            return -1; //значит значения нет в массиве
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string temp = cleanText(a);
            comboBox1.Items.Clear(); //очистить список
            if (temp != "")
            {
                int lenKey = testKasiski(temp);
                if (lenKey == -1 || lenKey == 0)
                {
                    MessageBox.Show("Невозможно провести криптоанализ", "Ошибка криптоанализа");
                    return;
                }    
                string[] C = new string[lenKey]; //создаем массив строк
                for (int i = 0; i < temp.Length; i++)
                {
                    //на каждую позицию, расстояние между которыми равно длине ключа, добавляем символ
                    C[i % lenKey] += temp[i];
                }
                string[] keys = new string[mostUse.Length];
                for (int k = 0; k < mostUse.Length; k++)
                {
                    string b = ""; //строка ключа
                    for (int i = 0; i < C.Length; i++)
                    {
                        float[] curChas = chastota(C[i]); //получаем частоты текущего фрагмента
                        float maxChas = curChas.Max(); //находим максимальную частоту
                        int ind = index(curChas, maxChas); //находим индекс (номер буквы), которя имеет наибольшую частоту
                                                           //отсюда можно сделать предположение, что это и есть буква О в зашифрованном виде
                                                           //от индекса самой встречаемой буквы отнимаем индекс О как самой частой буквы
                                                           //тем самым получаем индекс буквы, которая использовалась для ключа
                                                           //+33) % 33 чтобы не получать отрицательные значения
                        int indKey = (ind - mostUse[k] + len_alpha) % len_alpha;
                        b += alpha[indKey]; //заполняем ключ
                    }
                    keys[k] = b;
                }
                comboBox1.Items.AddRange(keys); //добавляем список ключей
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Введите зашифрованный текст", "Пустой текст");
            }
        }

        private string decrypt(string a, string b)
        {
            string c = "";
            int j = 0; //перебирает индексы ключа
                       //перебираем каждый индекс в строке a
            for (int i = 0; i < a.Length; i++)
            {
                //если символ содержится в алфавите
                if (alpha.Contains(a[i].ToString().ToLower()) == true)
                {
                    bool upper = false; //проверяем регистр буквы
                    if (a[i] >= 'А' && a[i] <= 'Я')
                    {
                        upper = true;
                    }
                    // находим индекс i-го символа из введенного текста в алфавите
                    int code_a = alpha.IndexOf(a[i].ToString().ToLower());
                    if (j >= b.Length) // если индекс ключа превышает длину ключа
                        j = 0; //сбрасываем индекс ключа
                    int code_b = alpha.IndexOf(b[j]);
                    j++; //увеличиваем индекс ключа на 1
                         //шифруем i-ый символ 
                    int code_c = (code_a - code_b + 33) % 33; //находим индекс зашифрованного символа
                    if (upper == true)
                        c += alpha[code_c].ToString().ToUpper(); //получаем символ в верхнем регистре
                    else
                        c += alpha[code_c]; //получаем символ
                }
                else
                    c += a[i]; //сохраняем текущий символ
            }
            return c;
        }

        private bool checkKey(string b)
        {
            foreach (char x in b) //перебираем каждый символ из ключа
            {
                //если встречается символ, который не содержится в алфавите
                if (alpha.Contains(x) == false)
                    return false; //ключ не подходит
            }
            return true; //ключ подходит
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string b = comboBox1.Text;
            if (a == "")
            {
                MessageBox.Show("Введите зашифрованный текст", "Пустой текст");
            }
            else if (b == "")
            {
                MessageBox.Show("Введите ключ", "Ошибка ключа");
            }
            else if (checkKey(b) == false)
            {
                MessageBox.Show("Ключ содержит недопустимые символы", "Ошибка ключа");
                comboBox1.Text = ""; //очищаем поле ключа
            }
            else
            {
                richTextBox2.Text = decrypt(a, b); //проводим расшифровку текста с зашифрованным текстом и ключом
                                                   //richTextBox2.Text = decrypt(a, b);
            }
        }
    }
}
