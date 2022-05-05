using System;
using System.Windows.Forms;

namespace Try_MP
{
    public partial class AddForm : Form
    {
        public event MyDelegate MyDelegateEventAdd;
        public delegate void MyDelegate(object o1, object o2, object o3, object o4, object o5);
        
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*bool digit = false;
            bool letter = false;
            foreach (var item in textBox1.Text)
            {
                if (char.IsDigit(item))
                {
                    digit = true;
                }
            }
            foreach (var item in textBox4.Text)
            {
                if (!char.IsDigit(item))
                {
                    letter = true;
                }
            }
            foreach (var item in textBox5.Text)
            {
                if (!char.IsDigit(item))
                {
                    letter = true;
                }
            }
            /*if ((digit||letter||int.Parse(textBox4.Text)>=int.Parse(textBox5.Text))&&textBox1 == null&&textBox2 == null
                 &&textBox3 == null&&textBox4 == null&&textBox5 == null)
            {
                Exception exception = new Exception();
                exception.Show();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else*/
            
            MyDelegateEventAdd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            
        }
    }
}