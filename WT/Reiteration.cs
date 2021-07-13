using System;
using System.Windows.Forms;
using System.IO;

namespace WT
{
    public partial class Reiteration : Form
    {
        class Words     //класс для массива слов и их переводов
        {
            public string eng;
            public string rus;
        }

        class I    //количество слов
        {
            static public int i = File.ReadAllLines("studied_eng.txt").Length;
        }

        void ArrInfill()    //заполнение массивов
        {
            //заполнение массива всех слов
            using (StreamReader sr1 = new StreamReader("studied_eng.txt", System.Text.Encoding.Default))
            using (StreamReader sr2 = new StreamReader("studied_rus.txt", System.Text.Encoding.Default))
            {
                for (int a = 0; a < I.i; a++)
                {
                    all[a] = new Words();
                    all[a].eng = sr1.ReadLine();
                    all[a].rus = sr2.ReadLine();
                }
            }

            //заполнение массиво выбранных слов неповторяющимся рандомом
            for (int a = 0; a < 20; a++)
            {
                rnd = rand.Next(I.i);
                selected[a] = all[rnd];
                cltemp = all[rnd];
                all[rnd] = all[I.i - 1];
                all[I.i - 1] = cltemp;
                I.i--;
            }

            //заполнение массива всех переводов
            for (int a = 0; a < all.Length; a++)
            {
                translations[a] = all[a].rus;
            }
        }

        void PutTranslate(int a, int ind, int index, RadioButton word)
        {
            if (a != index)
            {
                do
                {
                    rnd = rand.Next(num);
                }
                while (translations[rnd] == selected[ind].rus);

                word.Text = translations[rnd];
                temp = translations[rnd];
                translations[rnd] = translations[num - 1];
                translations[num - 1] = temp;
                num--;
            }
        }

        void Infill(int ind)    //функция для заполнения слова, вариантов переводов и прогресса
        {
            Word.Text = selected[ind].eng;
            int index = rand.Next(1, 6);
            switch (index)      //ставлю правильный перевод в рандомное место
            {
                case 1:
                    word1.Text = selected[ind].rus;
                    break;
                case 2:
                    word2.Text = selected[ind].rus;
                    break;
                case 3:
                    word3.Text = selected[ind].rus;
                    break;
                case 4:
                    word4.Text = selected[ind].rus;
                    break;
                case 5:
                    word5.Text = selected[ind].rus;
                    break;
            }

            for (int a = 1; a < 6; a++)
            {
                switch (a)
                {
                    case 1:
                        PutTranslate(a, ind, index, word1);
                        break;
                    case 2:
                        PutTranslate(a, ind, index, word2);
                        break;
                    case 3:
                        PutTranslate(a, ind, index, word3);
                        break;
                    case 4:
                        PutTranslate(a, ind, index, word4);
                        break;
                    case 5:
                        PutTranslate(a, ind, index, word5);
                        break;
                }
            }
        }

        void ShowTrue()     //показывает зелёным правильное слово
        {
            if (word1.Text == selected[n - 1].rus)
            {
                word1.BackColor = System.Drawing.Color.Lime;
            }

            else if (word2.Text == selected[n - 1].rus)
            {
                word2.BackColor = System.Drawing.Color.Lime;
            }

            else if (word3.Text == selected[n - 1].rus)
            {
                word3.BackColor = System.Drawing.Color.Lime;
            }

            else if (word4.Text == selected[n - 1].rus)
            {
                word4.BackColor = System.Drawing.Color.Lime;
            }

            else if (word5.Text == selected[n - 1].rus)
            {
                word5.BackColor = System.Drawing.Color.Lime;
            }
        }

        void ShowColor(RadioButton word)
        {
            if (word.Text == selected[n - 1].rus)
            {
                word.BackColor = System.Drawing.Color.Lime;
                result++;
            }
            else
            {
                word.BackColor = System.Drawing.Color.Red;
                ShowTrue();
            }
        }

        int rnd;    //переменная для запоминания рандома
        int num = I.i;
        int n = 1;  //счётчик итераций в тесте
        Random rand = new Random();
        string temp;   //переменная для перестановки местами
        Words[] selected = new Words[20];   //слова, которые будут использоваться в тесте
        Words cltemp;
        Words[] all = new Words[I.i];
        string[] translations = new string[I.i];
        static public int result = 0;     //количество угаданных слов

        public Reiteration()
        {
            InitializeComponent();
            MouseDown += delegate
            {
                Capture = false;
                var msg = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            };

            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            enter.FlatAppearance.BorderSize = 0;
            enter.FlatStyle = FlatStyle.Flat;

            ArrInfill();

            Infill(0);
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            word1.Checked = false;
            word2.Checked = false;
            word3.Checked = false;
            word4.Checked = false;
            word5.Checked = false;

            word1.BackColor = default;
            word2.BackColor = default;
            word3.BackColor = default;
            word4.BackColor = default;
            word5.BackColor = default;

            word1.Enabled = true;
            word2.Enabled = true;
            word3.Enabled = true;
            word4.Enabled = true;
            word5.Enabled = true;

            enter.Enabled = true;

            if (n < 20)
            {
                n++;
                number.Text = n + " / 20";
                num = translations.Length;
                Infill(n - 1);
            }

            //при завершении 20 итераций появляется окно вывода
            else
            {
                I.i = File.ReadAllLines("studying_eng.txt").Length;

                Result frm = new Result();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
            }
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //блокировка кнопок
            word1.Enabled = false;
            word2.Enabled = false;
            word3.Enabled = false;
            word4.Enabled = false;
            word5.Enabled = false;

            enter.Enabled = false;

            //меняет цвет фона
            if (word1.Checked == true)
            {
                ShowColor(word1);
            }

            else if (word2.Checked == true)
            {
                ShowColor(word2);
            }

            else if (word3.Checked == true)
            {
                ShowColor(word3);
            }

            else if (word4.Checked == true)
            {
                ShowColor(word4);
            }

            else if (word5.Checked == true)
            {
                ShowColor(word5);
            }
        }
    }
}
