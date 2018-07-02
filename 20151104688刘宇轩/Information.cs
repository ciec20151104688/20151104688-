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
    public partial class Information : Form
    {
        DataGridView dataGridView1;
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
