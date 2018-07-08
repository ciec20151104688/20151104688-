namespace _20151104688刘宇轩
{
    partial class Formlog
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.logbtn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValidCode = new System.Windows.Forms.TextBox();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 25);
            this.txtName.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(248, 93);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(199, 25);
            this.txtPwd.TabIndex = 3;
            // 
            // logbtn
            // 
            this.logbtn.Location = new System.Drawing.Point(281, 289);
            this.logbtn.Name = "logbtn";
            this.logbtn.Size = new System.Drawing.Size(75, 23);
            this.logbtn.TabIndex = 4;
            this.logbtn.Text = "登陆";
            this.logbtn.UseVisualStyleBackColor = true;
            this.logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(254, 337);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(102, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "注册用户";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "验证码：";
            // 
            // txtValidCode
            // 
            this.txtValidCode.Location = new System.Drawing.Point(248, 144);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(199, 25);
            this.txtValidCode.TabIndex = 7;
            // 
            // picValidCode
            // 
            this.picValidCode.Location = new System.Drawing.Point(248, 206);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(189, 50);
            this.picValidCode.TabIndex = 8;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // Formlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_20151104688刘宇轩.Resource1._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(577, 398);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.logbtn);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formlog";
            this.Text = "登陆系统";
            this.Load += new System.EventHandler(this.Formlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button logbtn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValidCode;
        private System.Windows.Forms.PictureBox picValidCode;
    }
}

