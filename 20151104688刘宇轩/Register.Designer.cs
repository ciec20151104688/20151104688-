namespace _20151104688刘宇轩
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtregistername = new System.Windows.Forms.TextBox();
            this.txtregisterpass = new System.Windows.Forms.TextBox();
            this.txtresurepass = new System.Windows.Forms.TextBox();
            this.btnregisterok = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "新用户：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // txtregistername
            // 
            this.txtregistername.Location = new System.Drawing.Point(164, 49);
            this.txtregistername.Name = "txtregistername";
            this.txtregistername.Size = new System.Drawing.Size(100, 25);
            this.txtregistername.TabIndex = 3;
            // 
            // txtregisterpass
            // 
            this.txtregisterpass.Location = new System.Drawing.Point(164, 113);
            this.txtregisterpass.Name = "txtregisterpass";
            this.txtregisterpass.Size = new System.Drawing.Size(100, 25);
            this.txtregisterpass.TabIndex = 4;
            // 
            // txtresurepass
            // 
            this.txtresurepass.Location = new System.Drawing.Point(164, 182);
            this.txtresurepass.Name = "txtresurepass";
            this.txtresurepass.Size = new System.Drawing.Size(100, 25);
            this.txtresurepass.TabIndex = 5;
            // 
            // btnregisterok
            // 
            this.btnregisterok.Location = new System.Drawing.Point(72, 232);
            this.btnregisterok.Name = "btnregisterok";
            this.btnregisterok.Size = new System.Drawing.Size(75, 23);
            this.btnregisterok.TabIndex = 6;
            this.btnregisterok.Text = "注册";
            this.btnregisterok.UseVisualStyleBackColor = true;
            this.btnregisterok.Click += new System.EventHandler(this.btnregisterok_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnregisterok);
            this.Controls.Add(this.txtresurepass);
            this.Controls.Add(this.txtregisterpass);
            this.Controls.Add(this.txtregistername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtregistername;
        private System.Windows.Forms.TextBox txtregisterpass;
        private System.Windows.Forms.TextBox txtresurepass;
        private System.Windows.Forms.Button btnregisterok;
        private System.Windows.Forms.Button button2;
    }
}