using System;
using System.Windows.Forms;

namespace WT
{
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
