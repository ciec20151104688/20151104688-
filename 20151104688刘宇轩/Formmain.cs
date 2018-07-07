using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _20151104688刘宇轩
{
    public partial class Formmain : Form
    {
        MySqlConnection conn;   // mysql连接
        MySqlDataAdapter myadp; // mysql数据适配器
        DataSet myds;   // 数据集
        public static DataTable dt = new DataTable();
        private string user;
        private string pwd;

        public Formmain()
        {
            InitializeComponent();
            DataColumn name = new DataColumn("name");
            DataColumn sex = new DataColumn("sex");
            DataColumn age = new DataColumn("age");
            DataColumn num = new DataColumn("num");
            DataColumn time = new DataColumn("time");       // DataColumn colInterest = new DataColumn("colInterest");
            dt.Columns.Add(name);
            dt.Columns.Add(sex);
            dt.Columns.Add(age);
            dt.Columns.Add(num);
            dt.Columns.Add(time);
           
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
            string MyConnectionString;
            MyConnectionString = "server = localhost; uid = root; pwd = 123456; database = parkinglot;Charset=utf8";
            try
            {
                //打开菜单配置数据库连接
                conn = new MySqlConnection();   // 实例化数据库连接（instanced）
                conn.ConnectionString = MyConnectionString;   // 配置连接（configured）
                conn.Open();   // 打开连接（opened）
                myadp = new MySqlDataAdapter("select * from carinfor", conn);
                myds = new DataSet();
                // 填充和绑定数据
                ; myadp.Fill(myds, "carinfor");
                BindingSource bindingSource1= new BindingSource();
                bindingSource1.DataSource = myds.Tables["carinfor"];
                dataGridView1.DataSource = bindingSource1;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("不能连接到数据库服务器，请联系数据库管理员！"); break;
                    case 1045:
                        MessageBox.Show("无效的用户名/密码,请重试！"); break;
                    case 1049:
                        MessageBox.Show("数据库不存在，或数据库名错误"); break;
                    default:
                        MessageBox.Show(ex.Message); break;
                }
            }
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
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FreedomCarEnter freecarEnter = new FreedomCarEnter();
            freecarEnter.Show();
            this.Close();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


              
        }
   
            
}


