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
        public Formmain()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("D:\\2.jpg");
        }

        public Formmain(string str)
        {
            InitializeComponent();
            label11.Text = str;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                TreeNode a = e.Node;
                string nodename = a.Name;
                switch (nodename)
                {
                    case "zhangsan":
                        Image img1 = Image.FromFile(@"C:\Users\ASUS123\Pictures\1.jpg");
                        photo.Image = img1;
                        label3.Text = "张三";
                        label4.Text = "一班";
                        label5.Text = "班长";
                        label6.Text = "2000000";
                        label7.Text = "10";
                        label8.Text = "中国";
                        break;
                    case "lisi":
                        Image img2 = Image.FromFile(@"C:\Users\ASUS123\Pictures\2.jpg");
                        photo.Image = img2;
                        label3.Text = "李四";
                        label4.Text = "一班";
                        label5.Text = "班长";
                        label6.Text = "2000000";
                        label7.Text = "10";
                        label8.Text = "中国";
                        break;
                    case "wangwu":
                        Image img3 = Image.FromFile(@"C:\Users\ASUS123\Pictures\3.jpg");
                        photo.Image = img3;
                        label3.Text = "王五";
                        label4.Text = "二班";
                        label5.Text = "班长";
                        label6.Text = "2000000";
                        label7.Text = "10";
                        label8.Text = "中国";
                        break;
                    case "zhaoqi":
                        Image img4 = Image.FromFile(@"C:\Users\ASUS123\Pictures\4.jpg");
                        photo.Image = img4;
                        label3.Text = "赵六";
                        label4.Text = "二班";
                        label5.Text = "班长";
                        label6.Text = "2000000";
                        label7.Text = "10";
                        label8.Text = "中国";
                        break;
                }
            }
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
    }
}
