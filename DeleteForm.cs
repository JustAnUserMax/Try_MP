using System;
using System.Windows.Forms;

namespace Try_MP
{
    public partial class DeleteForm : Form
    {
        public event MyDelegate MyDelegateEventDelete;
        public delegate void MyDelegate(string s);
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDelegateEventDelete(textBox1.Text);
        }
    }
}