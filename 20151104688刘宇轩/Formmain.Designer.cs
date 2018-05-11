namespace _20151104688刘宇轩
{
    partial class Formmain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("张三");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("李四");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("一层业主", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("王五");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("赵7");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("二层业主", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.text_admin_name = new System.Windows.Forms.TextBox();
            this.text_admin_id = new System.Windows.Forms.TextBox();
            this.text_admin_age = new System.Windows.Forms.TextBox();
            this.text_admin_tel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.text_admin_password = new System.Windows.Forms.TextBox();
            this.text_admin_password2 = new System.Windows.Forms.TextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_leave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "系统状态";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前登陆用户：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 123);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "zhangsan";
            treeNode13.Text = "张三";
            treeNode14.Name = "lisi";
            treeNode14.Text = "李四";
            treeNode15.Name = "节点0";
            treeNode15.Text = "一层业主";
            treeNode16.Name = "wangwu";
            treeNode16.Text = "王五";
            treeNode17.Name = "zhaoqi";
            treeNode17.Text = "赵7";
            treeNode18.Name = "节点4";
            treeNode18.Text = "二层业主";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(121, 112);
            this.treeView1.TabIndex = 1;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.photo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(157, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 208);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "国籍：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "月薪：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "停车场编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(18, 49);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(84, 135);
            this.photo.TabIndex = 1;
            this.photo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "照片信息";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(929, 435);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "管理员信息";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_save);
            this.groupBox4.Controls.Add(this.text_admin_password2);
            this.groupBox4.Controls.Add(this.text_admin_password);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.text_admin_tel);
            this.groupBox4.Controls.Add(this.text_admin_age);
            this.groupBox4.Controls.Add(this.text_admin_id);
            this.groupBox4.Controls.Add(this.text_admin_name);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(654, 286);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "管理员信息";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "姓名";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "账号";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "年龄";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "电话";
            // 
            // text_admin_name
            // 
            this.text_admin_name.Location = new System.Drawing.Point(93, 36);
            this.text_admin_name.Name = "text_admin_name";
            this.text_admin_name.Size = new System.Drawing.Size(136, 25);
            this.text_admin_name.TabIndex = 4;
            // 
            // text_admin_id
            // 
            this.text_admin_id.Location = new System.Drawing.Point(93, 72);
            this.text_admin_id.Name = "text_admin_id";
            this.text_admin_id.Size = new System.Drawing.Size(136, 25);
            this.text_admin_id.TabIndex = 5;
            // 
            // text_admin_age
            // 
            this.text_admin_age.Location = new System.Drawing.Point(93, 105);
            this.text_admin_age.Name = "text_admin_age";
            this.text_admin_age.Size = new System.Drawing.Size(136, 25);
            this.text_admin_age.TabIndex = 6;
            // 
            // text_admin_tel
            // 
            this.text_admin_tel.Location = new System.Drawing.Point(93, 146);
            this.text_admin_tel.Name = "text_admin_tel";
            this.text_admin_tel.Size = new System.Drawing.Size(136, 25);
            this.text_admin_tel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "修改信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 9;
            this.label16.Text = "密码";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(261, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "确认密码";
            // 
            // text_admin_password
            // 
            this.text_admin_password.Location = new System.Drawing.Point(353, 24);
            this.text_admin_password.Name = "text_admin_password";
            this.text_admin_password.Size = new System.Drawing.Size(100, 25);
            this.text_admin_password.TabIndex = 11;
            // 
            // text_admin_password2
            // 
            this.text_admin_password2.Location = new System.Drawing.Point(353, 69);
            this.text_admin_password2.Name = "text_admin_password2";
            this.text_admin_password2.Size = new System.Drawing.Size(100, 25);
            this.text_admin_password2.TabIndex = 12;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(195, 220);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "保存修改";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(929, 435);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "停车场状态";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(929, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "收费记录";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "车辆管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_leave);
            this.groupBox3.Controls.Add(this.button_enter);
            this.groupBox3.Location = new System.Drawing.Point(361, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 95);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "进出管理";
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(10, 25);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "进入";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_leave
            // 
            this.button_leave.Location = new System.Drawing.Point(10, 58);
            this.button_leave.Name = "button_leave";
            this.button_leave.Size = new System.Drawing.Size(75, 23);
            this.button_leave.TabIndex = 1;
            this.button_leave.Text = "离开";
            this.button_leave.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 464);
            this.tabControl1.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(343, 288);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "停车场状态";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "剩余车位：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(166, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "label19";
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formmain";
            this.Text = "停车场管理系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox text_admin_password2;
        private System.Windows.Forms.TextBox text_admin_password;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_admin_tel;
        private System.Windows.Forms.TextBox text_admin_age;
        private System.Windows.Forms.TextBox text_admin_id;
        private System.Windows.Forms.TextBox text_admin_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_leave;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}