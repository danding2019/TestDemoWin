namespace TestDemo
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RebackBtn = new System.Windows.Forms.Button();
            this.CheckRegisterBtn = new System.Windows.Forms.Button();
            this.MobileNumtxt = new System.Windows.Forms.TextBox();
            this.PassWordtxt2 = new System.Windows.Forms.TextBox();
            this.PassWordtxt = new System.Windows.Forms.TextBox();
            this.UserIdtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RebackBtn);
            this.panel1.Controls.Add(this.CheckRegisterBtn);
            this.panel1.Controls.Add(this.MobileNumtxt);
            this.panel1.Controls.Add(this.PassWordtxt2);
            this.panel1.Controls.Add(this.PassWordtxt);
            this.panel1.Controls.Add(this.UserIdtxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(83, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 269);
            this.panel1.TabIndex = 0;
            // 
            // RebackBtn
            // 
            this.RebackBtn.Location = new System.Drawing.Point(89, 216);
            this.RebackBtn.Name = "RebackBtn";
            this.RebackBtn.Size = new System.Drawing.Size(124, 23);
            this.RebackBtn.TabIndex = 11;
            this.RebackBtn.Text = "返回至登录";
            this.RebackBtn.UseVisualStyleBackColor = true;
            this.RebackBtn.Click += new System.EventHandler(this.RebackBtn_Click);
            // 
            // CheckRegisterBtn
            // 
            this.CheckRegisterBtn.Location = new System.Drawing.Point(89, 187);
            this.CheckRegisterBtn.Name = "CheckRegisterBtn";
            this.CheckRegisterBtn.Size = new System.Drawing.Size(124, 23);
            this.CheckRegisterBtn.TabIndex = 10;
            this.CheckRegisterBtn.Text = "我已确认，注册!";
            this.CheckRegisterBtn.UseVisualStyleBackColor = true;
            this.CheckRegisterBtn.Click += new System.EventHandler(this.CheckRegisterBtn_Click);
            // 
            // MobileNumtxt
            // 
            this.MobileNumtxt.Location = new System.Drawing.Point(71, 160);
            this.MobileNumtxt.Name = "MobileNumtxt";
            this.MobileNumtxt.Size = new System.Drawing.Size(170, 21);
            this.MobileNumtxt.TabIndex = 9;
            this.MobileNumtxt.Validated += new System.EventHandler(this.MobileNumtxt_Validated);
            // 
            // PassWordtxt2
            // 
            this.PassWordtxt2.Location = new System.Drawing.Point(71, 112);
            this.PassWordtxt2.Name = "PassWordtxt2";
            this.PassWordtxt2.Size = new System.Drawing.Size(170, 21);
            this.PassWordtxt2.TabIndex = 8;
            this.PassWordtxt2.UseSystemPasswordChar = true;
            // 
            // PassWordtxt
            // 
            this.PassWordtxt.Location = new System.Drawing.Point(71, 70);
            this.PassWordtxt.Name = "PassWordtxt";
            this.PassWordtxt.Size = new System.Drawing.Size(170, 21);
            this.PassWordtxt.TabIndex = 7;
            this.PassWordtxt.UseSystemPasswordChar = true;
            // 
            // UserIdtxt
            // 
            this.UserIdtxt.Location = new System.Drawing.Point(71, 34);
            this.UserIdtxt.Name = "UserIdtxt";
            this.UserIdtxt.Size = new System.Drawing.Size(170, 21);
            this.UserIdtxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "手机号码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 459);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckRegisterBtn;
        private System.Windows.Forms.TextBox MobileNumtxt;
        private System.Windows.Forms.TextBox PassWordtxt2;
        private System.Windows.Forms.TextBox PassWordtxt;
        private System.Windows.Forms.TextBox UserIdtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RebackBtn;
    }
}