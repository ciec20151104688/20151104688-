using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _20151104688刘宇轩
{
    public partial class Formlog : Form
    {
        public Formlog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pass = textBox2.Text;

            if(name == "admin"&& pass == "123456"||name == "tset"&& pass == "123456")
            {
                Formmain form = new Formmain(textBox1.Text);
                form.ShowDialog();
                this.Hide();
            }

            else
            {
                MessageBox.Show("密码错误");
                textBox1.Text = null;
                textBox2.Text = null;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
