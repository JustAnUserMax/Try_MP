using System;
using System.Windows.Forms;

namespace Try_MP
{
    public partial class EditForm : Form
    {
        public event MyDelegate MyDelegateEventEdit;
        public delegate void MyDelegate(object o1, object o2);
        public EditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDelegateEventEdit(textBox1.Text, textBox2.Text);
        }
    }
}