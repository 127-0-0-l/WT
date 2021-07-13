using System;
using System.Windows.Forms;
using System.IO;

namespace WT
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();

            MouseDown += delegate
            {
                Capture = false;
                var msg = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            };

            richTextBox1.ReadOnly = true;
            richTextBox2.ReadOnly = true;

            string StudyingEng = "studying_eng.txt";
            string StudyingRus = "studying_rus.txt";
            string StudiedEng = "studied_eng.txt";
            string StudiedRus = "studied_rus.txt";

            using (StreamReader sr1 = new StreamReader(StudyingEng, System.Text.Encoding.Default))
            {
                using (StreamReader sr2 = new StreamReader(StudyingRus, System.Text.Encoding.Default))
                {
                    string line1;
                    string line2;
                    while ((line1 = sr1.ReadLine()) != null && (line2 = sr2.ReadLine()) != null)
                    {
                        richTextBox1.Text += line1 + " - " + line2 + "\n";
                    }
                }
            }

            using (StreamReader sr1 = new StreamReader(StudiedEng, System.Text.Encoding.Default))
            {
                using (StreamReader sr2 = new StreamReader(StudiedRus, System.Text.Encoding.Default))
                {
                    string line1;
                    string line2;
                    while ((line1 = sr1.ReadLine()) != null && (line2 = sr2.ReadLine()) != null)
                    {
                        richTextBox2.Text += line1 + " - " + line2 + "\n";
                    }
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
