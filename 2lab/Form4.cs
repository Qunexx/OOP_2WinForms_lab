using lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2lab
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели значения"); //Ничего не делаем
            }
            else
            {
                textBox3.Clear();
                textBox4.Clear();
                double xn = Convert.ToDouble(textBox1.Text);
                double xk = Convert.ToDouble(textBox2.Text);


                double[] nums = Mylib.MathF11x(xn, xk);


                for (int i = 0; i < nums.Length; i++)
                {
                    textBox3.Text += " \n\n\n\n\n\n" + nums[i].ToString("F3") + Environment.NewLine;

                }

                double[] nums1 = Mylib.MathF11f(xn, xk);

                for (int i = 0; i < nums1.Length; i++)
                {

                    textBox4.Text += " \n\n\n\n\n\n" + nums1[i].ToString("F3") + Environment.NewLine;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            double S;
            int n, N;
            double xk = 1;
            double xn = 0.1;
            double h = (xk - xn) / 10;
            N = 16;
            for (double x = xn; x <= xk; x += h) //Цикл задающий изменение x от xn до xk с шагом h
            {

                Mylib.MathF2(x);
                textBox5.Text += x.ToString("F3") + Environment.NewLine;
                textBox6.Text += Mylib.MathF2(x).ToString("F3") + Environment.NewLine;
            }


        }
    }
}
