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
    public partial class Formmain : Form
    {
        private string user;
        private string pwd;

        public Formmain()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\2.jpg");
        }

        public Formmain(string str)
        {
            InitializeComponent();
            tname.Text = str;
        }

        public Formmain(string user, string pwd)
        {
            // TODO: Complete member initialization
            this.user = user;
            this.pwd = pwd;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void 业主信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            FreedomCarEnter freecarEnter = new FreedomCarEnter();
            freecarEnter.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.text_admin_name.ReadOnly = false;
            this.text_admin_tel.ReadOnly = false;
            this.text_admin_id.ReadOnly = false;
            this.text_admin_password.ReadOnly = false;
            this.text_admin_password2.ReadOnly = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (this.text_admin_password.Text == "" && this.text_admin_password2.Text == "")
            {
            }
            else if (this.text_admin_password.Text != this.text_admin_password2.Text)
            {
                MessageBox.Show("两次输入的密码不一致！请重新输入");
                this.text_admin_password.Text = "";
                this.text_admin_password2.Text = "";
            }
            else
            {
            }
              
        }

        private void button_leave_Click(object sender, EventArgs e)
        {

        }
    }
}
