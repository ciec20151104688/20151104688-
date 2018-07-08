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
    public partial class pay : Form
    {
        DateTime a = Information.arrival;
        DateTime c = DateTime.Now;
        public pay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pay_Load(object sender, EventArgs e)
        {
           TimeSpan span =c  -  a;
        }

        private void span_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        
    }
}
