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

namespace _2lab
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "" || textBox2.Text == "")
            {
                ; //Ничего не делаем
            }
            else*/

                int m = int.Parse(textBox1.Text);
                string[] sNums = textBox2.Text.Split(' ');
                
                int[] nums = new int[m];
                for (int i = 0; i < m; i++)
                {
                    nums[i] = int.Parse(sNums[i]);
                }

                for (int i = 0; i < m; i++)
                {
                    textBox3.Text += " " + nums[i];


                }

                for (int i = 0; i <= m; i++)
                {
                    textBox4.Text += Mylib.MassivCheck(m, nums);

                }

            
            
        }
    }
}
