using System;
using System.Windows.Forms;

namespace WT
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();

            MouseDown += delegate
            {
                Capture = false;
                var msg = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            };

            label1.Text = "Right: " + Testing.result;
            label2.Text = "no right: " + (20 - Testing.result);
            Testing.result = 0;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
