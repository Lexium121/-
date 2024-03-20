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
        string alpha = "��������������������������������";
        int len_alpha = 33;

        private bool checkKey(string b)
        {
            foreach (char x in b) //���������� ������ ������ �� �����
            {
                //���� ����������� ������, ������� �� ���������� � ��������
                if (alpha.Contains(x) == false)
                    return false; //���� �� ��������
            }
            return true; //���� ��������
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string b = textBox1.Text.ToLower(); //���� � ������ ��������
            if (checkKey(b) == false)
            {
                MessageBox.Show("���� �������� ������������ �������", "������ �����");
                textBox1.Text = ""; //������� ���� �����
            }
            else if (b == "")
            {
                MessageBox.Show("������� ����", "������ �����");
            }
            else if (a == "")
            {
                MessageBox.Show("������� �����, ������� ������ �����������", "������ �����");
            }
            else
            {
                string c = "";
                int j = 0; //���������� ������� �����
                           //���������� ������ ������ � ������ a
                for (int i = 0; i < a.Length; i++)
                {
                    //���� ������ ���������� � ��������
                    if (alpha.Contains(a[i].ToString().ToLower()) == true)
                    {
                        bool upper = false; //��������� ������� �����
                        if (a[i] >= '�' && a[i] <= '�')
                        {
                            upper = true;
                        }
                        // ������� ������ i-�� ������� �� ���������� ������ � ��������
                        int code_a = alpha.IndexOf(a[i].ToString().ToLower());
                        if (j >= b.Length) // ���� ������ ����� ��������� ����� �����
                            j = 0; //���������� ������ �����
                        int code_b = alpha.IndexOf(b[j]);
                        j++; //����������� ������ ����� �� 1
                             //������� i-�� ������ 
                        int code_c = (code_a + code_b) % len_alpha; //������� ������ �������������� �������
                        if (upper == true)
                            c += alpha[code_c].ToString().ToUpper(); //�������� ������ � ������� ��������
                        else
                            c += alpha[code_c]; //�������� ������
                    }
                    else
                        c += a[i]; //��������� ������� ������

                }
                richTextBox2.Text = c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text;
            string b = textBox1.Text.ToLower(); //���� � ������ ��������
            if (checkKey(b) == false)
            {
                MessageBox.Show("���� �������� ������������ �������", "������ �����");
                textBox1.Text = ""; //������� ���� �����
            }
            else if (a == "")
            {
                MessageBox.Show("������� ������������� �����", "������ �����");
            }
            else
            {
                string c = "";
                int j = 0; //���������� ������� �����
                           //���������� ������ ������ � ������ a
                for (int i = 0; i < a.Length; i++)
                {
                    //���� ������ ���������� � ��������
                    if (alpha.Contains(a[i].ToString().ToLower()) == true)
                    {
                        bool upper = false; //��������� ������� �����
                        if (a[i] >= '�' && a[i] <= '�')
                        {
                            upper = true;
                        }
                        // ������� ������ i-�� ������� �� ���������� ������ � ��������
                        int code_a = alpha.IndexOf(a[i].ToString().ToLower());
                        if (j >= b.Length) // ���� ������ ����� ��������� ����� �����
                            j = 0; //���������� ������ �����
                        int code_b = alpha.IndexOf(b[j]);
                        j++; //����������� ������ ����� �� 1
                             //������� i-�� ������ 
                        int code_c = (code_a - code_b + len_alpha) % len_alpha; //������� ������ �������������� �������
                        if (upper == true)
                            c += alpha[code_c].ToString().ToUpper(); //�������� ������ � ������� ��������
                        else
                            c += alpha[code_c]; //�������� ������
                    }
                    else
                        c += a[i]; //��������� ������� ������

                }
                richTextBox2.Text = c;
            }
        }
    }
}