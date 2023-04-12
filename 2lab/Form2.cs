using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Вы не ввели значения"); //Ничего не делаем
            }
            else { 
            double a = Convert.ToDouble( textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            
            double res = Mylib.linfunc(a, b, c);
            textBox4.Text =Convert.ToString(res);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
