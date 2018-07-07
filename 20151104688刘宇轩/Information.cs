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
    public partial class Information : Form
    {
        DataGridView dataGridView1;
        public static DataTable dt = new DataTable();
        public static DateTime arrival = DateTime.Now;
        DateTime leave = DateTime.Now;

        public Information()
        {
            InitializeComponent();
        }
        public Information(DataGridView _dataGridView1)
        {
            InitializeComponent();
            dataGridView1 = _dataGridView1;

        }
        private void button1_Click(object sender, EventArgs e)
        {



            if (this.name.Text == "")
            {
                MessageBox.Show("姓名不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.age.Text == "")
            {
                MessageBox.Show("年龄不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.sex.Text == "")
            {
                MessageBox.Show("性别不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (this.unm.Text == "")
            {
                MessageBox.Show("停车编号不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand("insert into parkinglot.carinfor(name,age,sex,num，time)values('" + name.Text + "','" + age.Text + "','" + sex.Text + "','" + unm.Text + "','" + time.Text + "')", connection);
                DataRow dr = FreedomCarEnter.dt.NewRow();
                dr["name"] = name.Text;
                dr["Sex"] = sex.Text;
                dr["Age"] = age.Text;
                dr["Num"] = unm.Text;
                dr["time"] = time.Text;
                FreedomCarEnter.dt.Rows.Add(dr);
                dataGridView1.DataSource = FreedomCarEnter.dt;


                if (
               command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("成功写入数据库");
                }
                else
                {
                    MessageBox.Show("写入失败");
                }
            }

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            time.Text = Convert.ToString(arrival);
        }
    }
}
