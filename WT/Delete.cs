using System;
using System.Windows.Forms;
using System.IO;

namespace WT
{
    public partial class Delete : Form
    {
        void Infill()
        {
            using (StreamReader sr1 = new StreamReader("studying_eng.txt", System.Text.Encoding.Default))
            {
                for (int i = 0; i < File.ReadAllLines("studying_eng.txt").Length; i++)
                {
                    comboBox1.Items.Add(sr1.ReadLine());
                }
            }
        }

        string str1, str2, str3;

        public Delete()
        {
            InitializeComponent();

            MouseDown += delegate
            {
                Capture = false;
                var msg = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            };

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;

            Infill();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr1 = new StreamReader("studying_eng.txt", System.Text.Encoding.Default))
            using (StreamWriter sw1 = new StreamWriter(@"new\studying_eng.txt", true, System.Text.Encoding.Default))
            using (StreamReader sr2 = new StreamReader("studying_rus.txt", System.Text.Encoding.Default))
            using (StreamWriter sw2 = new StreamWriter(@"new\studying_rus.txt", true, System.Text.Encoding.Default))
            using (StreamReader sr3 = new StreamReader("progress.txt", System.Text.Encoding.Default))
            using (StreamWriter sw3 = new StreamWriter(@"new\progress.txt", true, System.Text.Encoding.Default))
            {
                for (int i = 0; i < File.ReadAllLines("studying_eng.txt").Length; i++)
                {
                    str1 = sr1.ReadLine();
                    str2 = sr2.ReadLine();
                    str3 = sr3.ReadLine();
                    if (comboBox1.Text != str1)
                    {
                        sw1.WriteLine(str1);
                        sw2.WriteLine(str2);
                        sw3.WriteLine(str3);
                    }
                }
            }

            File.Copy(@"new\studying_eng.txt", "studying_eng.txt", true);
            File.Copy(@"new\studying_rus.txt", "studying_rus.txt", true);
            File.Copy(@"new\progress.txt", "progress.txt", true);
            File.Delete(@"new\studying_eng.txt");
            File.Delete(@"new\studying_rus.txt");
            File.Delete(@"new\progress.txt");

            comboBox1.Text = null;
            comboBox1.Items.Clear();
            Infill();
        }
    }
}
