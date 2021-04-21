using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Working_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            D.Text = "Введите пароль для разблокировки смены";
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
          //  sender = DateTime.Now;
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public string theQuestion;
        public string theAnswer;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
