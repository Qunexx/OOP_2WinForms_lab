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
    public partial class Form1 : Form
    {
        Form f;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = new Form3();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = new Form4();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            f = new Form5();
            f.Show();
        }
    }
}
