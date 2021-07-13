using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MouseDown += delegate
            {
                Capture = false;
                var msg = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            };

            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void english_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if((e.KeyChar > 64 & e.KeyChar < 91) || (e.KeyChar > 96 & e.KeyChar < 123) || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 32)
            {
                pictureBox1.BackColor = default;
            }
            else
            {
                e.Handled = true;
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void russian_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((e.KeyChar > 1039 & e.KeyChar < 1104) || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 32)
            {
                pictureBox2.BackColor = default;
            }
            else
            {
                e.Handled = true;
                pictureBox2.BackColor = Color.Red;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(english.Text != "" && russian.Text != "")
            {
                using (StreamWriter sw = new StreamWriter("studying_eng.txt", true, System.Text.Encoding.Default))
                    sw.WriteLine(english.Text);

                using (StreamWriter sw = new StreamWriter("studying_rus.txt", true, System.Text.Encoding.Default))
                    sw.WriteLine(russian.Text);

                using (StreamWriter sw = new StreamWriter("progress.txt", true, System.Text.Encoding.Default))
                    sw.WriteLine("0");
            }

            english.Text = null;
            russian.Text = null;
        }
    }
}
