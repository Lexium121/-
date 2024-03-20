using System.Diagnostics.Eventing.Reader;

namespace Vigener
{
    public partial class Shifr : Form
    {
        public Shifr()
        {
            InitializeComponent();
        }

        private static Shifr shifrForm;

        public static Shifr ShifrForm
        {
            get
            {
                if (shifrForm == null || shifrForm.IsDisposed)
                    shifrForm = new Shifr();
                return shifrForm;
            }
        }

        public void ShowForm()
        {
            Activate();
            Show();
        }
        string alpha = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int len_alpha = 33;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string b = textBox1.Text.ToLower(); //ключ в нижнем регистре
            if (checkKey(b) == false)
            {
                MessageBox.Show("Ключ содержит недопустимые символы", "Ошибка ключа");
                textBox1.Text = ""; //очищаем поле ключа
            }
            else if (b == "")
            {
                MessageBox.Show("Введите ключ", "Ошибка ключа");
            }
            else if (a == "")
            {
                MessageBox.Show("Введите текст, который хотите зашифровать", "Пустой текст");
            }
            else
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
                        int code_c = (code_a + code_b) % len_alpha; //находим индекс зашифрованного символа
                        if (upper == true)
                            c += alpha[code_c].ToString().ToUpper(); //получаем символ в верхнем регистре
                        else
                            c += alpha[code_c]; //получаем символ
                    }
                    else
                        c += a[i]; //сохраняем текущий символ

                }
                richTextBox2.Text = c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string b = textBox1.Text.ToLower(); //ключ в нижнем регистре
            if (checkKey(b) == false)
            {
                MessageBox.Show("Ключ содержит недопустимые символы", "Ошибка ключа");
                textBox1.Text = ""; //очищаем поле ключа
            }
            else if (a == "")
            {
                MessageBox.Show("Введите зашифрованный текст", "Пустой текст");
            }
            else
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
                        int code_c = (code_a - code_b + len_alpha) % len_alpha; //находим индекс зашифрованного символа
                        if (upper == true)
                            c += alpha[code_c].ToString().ToUpper(); //получаем символ в верхнем регистре
                        else
                            c += alpha[code_c]; //получаем символ
                    }
                    else
                        c += a[i]; //сохраняем текущий символ

                }
                richTextBox2.Text = c;
            }
        }
    }
}