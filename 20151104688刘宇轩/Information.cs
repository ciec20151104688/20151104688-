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
            string connectionString = "server=localhost;user = root;password=123456;Database=parkinglot;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand("insert into parkinglot.carinfor(name,age,sex,num)values('" + name.Text + "','" + age.Text + "','" + sex.Text + "','" + unm.Text + "')", connection);
            if (
                command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("1");
            }
            DataRow dr = FreedomCarEnter.dt.NewRow();

            dr["name"] = name.Text;
            dr["Sex"] = sex.Text;
            dr["Age"] = age.Text;
            dr["Num"] = unm.Text;
            FreedomCarEnter.dt.Rows.Add(dr);
            dataGridView1.DataSource = FreedomCarEnter.dt;
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Information_Load(object sender, EventArgs e)
        {

        }
    }
}
