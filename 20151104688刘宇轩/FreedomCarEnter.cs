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
using System.Threading;

namespace _20151104688刘宇轩
{
    public partial class FreedomCarEnter : Form
    {
        public static DataTable dt = new DataTable();
        public FreedomCarEnter()
        {
            InitializeComponent();
            new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                       textBox1.BeginInvoke(new MethodInvoker(() =>
                            textBox1.Text = DateTime.Now.ToString()));
                    }
                    catch { }
                    Thread.Sleep(1000);
                }
            }) { IsBackground = true }.Start();


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



        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void timestop_Click(object sender, EventArgs e)
        {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //1、弹出提示框，如果选择“是”，执行以下步骤。
            DialogResult ds = MessageBox.Show("是否结算停车费？？？", "提示", MessageBoxButtons.OKCancel);
            if (ds == DialogResult.OK)
            {
                pay paid = new pay();
                paid.Show();
            }

            else
            {
                MessageBox.Show("信息为空");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
