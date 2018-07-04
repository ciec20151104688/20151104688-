using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _20151104688刘宇轩
{
    public partial class Formlog : Form
    {
        String user;
        String pwd;
        public static Formlog pmain;
        public Formlog()
        {
            InitializeComponent();
            pmain = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {

        }

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            {
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection_username = new MySqlConnection(connectionString);
            MySqlConnection connection_userpass = new MySqlConnection(connectionString);
            connection_username.Open();
            connection_userpass.Open();
            MySqlCommand command1 = new MySqlCommand("SELECT username FROM parkinglot.userinf WHERE username = '" + txtName.Text + "'", connection_username);
            MySqlCommand command2 = new MySqlCommand("SELECT userpass FROM parkinglot.userinf WHERE userpass = '" + txtPwd.Text + "'", connection_userpass);
            MySqlDataReader reader1 = command1.ExecuteReader();
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (this.txtName.Text == "")
            {
                MessageBox.Show("用户名不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             else if (reader1.HasRows)
            {
                connection_username.Close();
                reader2.Read();
                pwd = reader2["userpass"].ToString();
                    if (txtPwd.Text == pwd)
                    {
                        pwd = reader2["userpass"].ToString();
                        user = txtName.Text;
                        pwd = txtPwd.Text;
                        Formmain fma = new Formmain(txtName.Text);
                        fma.Show();
                        this.Hide();
                    }
       
                    else
                    {
                        MessageBox.Show("密码输入错误，请重新输入！");
                        txtName.Text = "";
                        txtPwd.Text = "";

                    }
            }
            else
            {
                MessageBox.Show("用户名不存在");
            }  
                }       
                    }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Register frmregister = new Register();
            Formlog frmlogin = new Formlog();
            frmlogin.Hide();
            frmregister.Show();
        }
        }

}
 
   
