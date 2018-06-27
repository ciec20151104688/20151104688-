using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace _20151104688刘宇轩
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnregisterok_Click(object sender, EventArgs e)
        {
            Formlog frmlogin = new Formlog();
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("insert into parkinglot.userinf(username,userpass)values('" + txtregistername.Text + "','" + txtregisterpass.Text + "')", connection);
            if (txtregistername.TextLength <= 0 || txtregisterpass.TextLength <= 0)
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                if (txtresurepass.Text != txtregisterpass.Text)
                {
                    MessageBox.Show("两次密码输入不同，请重新输入！");
                }
                else
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("注册成功！");
                        frmlogin.Show();
                    }
                }
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult tip = MessageBox.Show("确定取消注册？", "提示",
              MessageBoxButtons.OKCancel);
            if (tip == DialogResult.OK)
            {
                this.Close();
            }
        }

       
    }
}
