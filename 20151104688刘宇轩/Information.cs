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
            DataRow dr = Formmain.dt.NewRow();
            dr["colName"] = userName.Text;
            dr["colSex"] = Sex.Text;
            dr["colAge"] = Age.Text;
            dr["colNum"] = Unm.Text;
            Formmain.dt.Rows.Add(dr);
            dataGridView1.DataSource = Formmain.dt;
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
