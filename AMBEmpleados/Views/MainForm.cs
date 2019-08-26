using System;
using System.Windows.Forms;

namespace AMBEmpleados.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            contentPane.Controls.Add(new Welcome());
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            contentPane.Controls.Clear();
            contentPane.Controls.Add(new Welcome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contentPane.Controls.Clear();
            contentPane.Controls.Add(new Add());
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            contentPane.Controls.Clear();
            contentPane.Controls.Add(new Modify());
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
            contentPane.Controls.Clear();
            contentPane.Controls.Add(new ListAll());
        }
    }
}
