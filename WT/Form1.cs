using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace WT
{
    public partial class Main : Form
    {
        void Butt(Button button) //стиль кнопок
        {
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
        }

        void FormCreate(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        public Main()
        {
            InitializeComponent();

            this.MouseDown += delegate
            {
                this.Capture = false;
                var msg = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            };

            Butt(Add);
            Butt(Testing);
            Butt(Repeat);
            Butt(Words);
            Butt(Delete);
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
            Form2 form = new Form2();   //добавление новых слов
            FormCreate(form);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("studying_eng.txt").Length < 20)
            {
                Error form = new Error();
                FormCreate(form);
            }
            else
            {
                Testing form = new Testing();
                FormCreate(form);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("studied_eng.txt").Length < 20)
            {
                Error form = new Error();
                FormCreate(form);
            }
            else
            {
                Reiteration form = new Reiteration();
                FormCreate(form);
            }
        }

        private void WearyWords_Click(object sender, EventArgs e)
        {
            Show form = new Show();
            FormCreate(form);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete form = new Delete();
            FormCreate(form);
        }
    }
}
