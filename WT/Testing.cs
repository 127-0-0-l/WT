using System;
using System.Windows.Forms;
using System.IO;

namespace WT
{
    public partial class Testing : Form
    {
        class Words     //класс для массива слов, их переводов и прогресса изучения
        {
            public string eng;
            public string rus;
            public int prog;
        }

        class I    //количество слов
        {
            static public int i = File.ReadAllLines("studying_eng.txt").Length;
        }

        void ArrInfill()    //заполнение массивов
        {
            //заполнение массива всех слов
            using (StreamReader sr1 = new StreamReader("studying_eng.txt", System.Text.Encoding.Default))
            using (StreamReader sr2 = new StreamReader("studying_rus.txt", System.Text.Encoding.Default))
            using (StreamReader sr3 = new StreamReader("progress.txt", System.Text.Encoding.Default))
            {
                for (int a = 0; a < I.i; a++)
                {
                    all[a] = new Words();
                    all[a].eng = sr1.ReadLine();
                    all[a].rus = sr2.ReadLine();
                    all[a].prog = Convert.ToInt32(sr3.ReadLine());
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

            progress.Value = selected[ind].prog;

            //расстановка переводов
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
            if(word1.Text == selected[n - 1].rus)
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
                selected[n - 1].prog++;
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

        public Testing()
        {
            InitializeComponent();

            //возможность перетаскивать форму за любое место
            MouseDown += delegate
            {
                Capture = false;
                var msg = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            };

            //стиль кнопок
            next.FlatAppearance.BorderSize = 0;
            next.FlatStyle = FlatStyle.Flat;
            enter.FlatAppearance.BorderSize = 0;
            enter.FlatStyle = FlatStyle.Flat;

            ArrInfill();

            Infill(0);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            I.i = File.ReadAllLines("studying_eng.txt").Length;
            Close();    //закрытие окна
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;    //свёртывание окна
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

                using (StreamWriter sw1 = new StreamWriter("progress.txt"))
                using (StreamWriter sw2 = new StreamWriter("studying_eng.txt"))
                using (StreamWriter sw3 = new StreamWriter("studying_rus.txt"))
                using (StreamWriter sw4 = new StreamWriter("studied_eng.txt"))
                using (StreamWriter sw5 = new StreamWriter("studied_rus.txt"))
                {
                    sw1.Write("");
                    sw2.Write("");
                    sw3.Write("");
                    sw4.Write("");
                    sw5.Write("");
                }

                //перезапись файлов
                using (StreamWriter sw1 = new StreamWriter("progress.txt", true, System.Text.Encoding.Default))
                using (StreamWriter sw2 = new StreamWriter("studying_eng.txt", true, System.Text.Encoding.Default))
                using (StreamWriter sw3 = new StreamWriter("studying_rus.txt", true, System.Text.Encoding.Default))
                using (StreamWriter sw4 = new StreamWriter("studied_eng.txt", true, System.Text.Encoding.Default))
                using (StreamWriter sw5 = new StreamWriter("studied_rus.txt", true, System.Text.Encoding.Default))
                {
                    for (int k = 0; k < all.Length; k++)
                    {
                        bool indicator = false;
                        for(int t = 0; t < 20; t++)
                        {
                            if(all[k] == selected[t])
                            {
                                indicator = true;
                                if(selected[t].prog == 10)
                                {
                                    sw4.WriteLine(selected[t].eng);
                                    sw5.WriteLine(selected[t].rus);
                                }
                                else
                                {
                                    sw1.WriteLine(selected[t].prog);
                                    sw2.WriteLine(selected[t].eng);
                                    sw3.WriteLine(selected[t].rus);
                                }
                            }
                        }
                        if(indicator == false)
                        {
                            sw1.WriteLine(all[k].prog);
                            sw2.WriteLine(all[k].eng);
                            sw3.WriteLine(all[k].rus);
                        }
                    }
                }

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
            if(word1.Checked == true)
            {
                ShowColor(word1);
            }

            else if(word2.Checked == true)
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

            progress.Value = selected[n - 1].prog;
        }
    }
}
