using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace _20151104688刘宇轩
{
    public partial class FreedomCarEnter : Form
    {
        TimeSpan TimeCount = new TimeSpan();
        System.DateTime TimeNow = new DateTime();
        public static DataTable dt = new DataTable();
        MySqlConnection conn;   // mysql连接
        MySqlDataAdapter myadp; // mysql数据适配器
        DataSet myds;   // 数据集




        


        public FreedomCarEnter()
        {
            InitializeComponent();
            DataColumn name = new DataColumn("name");
            DataColumn sex = new DataColumn("sex");
            DataColumn age = new DataColumn("age");
            DataColumn num = new DataColumn("num");
            DataColumn Where = new DataColumn("Where");            // DataColumn colInterest = new DataColumn("colInterest");
            dt.Columns.Add(name);
            dt.Columns.Add(sex);
            dt.Columns.Add(age);
            dt.Columns.Add(num);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            TimeNow = DateTime.Now;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeCount = DateTime.Now - TimeNow;
            timeshow.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);
        }

        private void timestop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            pictureBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Information information = new Information(dataGridView1);
            information.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //1、弹出提示框，如果选择“是”，执行以下步骤。
            DialogResult ds = MessageBox.Show("是否删除当前信息？？？", "提示", MessageBoxButtons.OKCancel);
            if (ds == DialogResult.OK)
            {
                //2、获取当前选中的行 索
                int index = dataGridView1.SelectedRows[0].Index;

                //3、从DataTable中查找要删除的信息。
                dt.Rows.RemoveAt(index);

                //4、重新绑定DatagridView；
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FreedomCarEnter_Load(object sender, EventArgs e)
        {
            string MyConnectionString;
            MyConnectionString = "server = localhost; uid = root; pwd = 123456; database = parkinglot";
            try
            {
                conn = new MySqlConnection();   // 实例化数据库连接（instanced）
                conn.ConnectionString = MyConnectionString;   // 配置连接（configured）
                conn.Open();   // 打开连接（opened）
                myadp = new MySqlDataAdapter("select * from carinfor", conn);



                myds = new DataSet();
                myadp.Fill(myds, "carinfor");
                BindingSource bindingSource1 = new BindingSource();
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

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string MyConnectionString;
            MyConnectionString = "server = localhost; uid = root; pwd = 123456; database = parkinglot";
            try
            {
                conn = new MySqlConnection();   // 实例化数据库连接（instanced）
                conn.ConnectionString = MyConnectionString;   // 配置连接（configured）
                conn.Open();   // 打开连接（opened）
                myadp = new MySqlDataAdapter("select * from carinfor", conn);
                myds = new DataSet();
                BindingSource bindingSource1 = new BindingSource();
                dataGridView1.DataSource = bindingSource1;
                bindingSource1.DataSource = myds.Tables["carinfor"];
                MySqlCommandBuilder mycb = new MySqlCommandBuilder(myadp);
                myadp.Update(myds, "insert into parkinglot.carinfor(name,sex)values");


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
    }
}
