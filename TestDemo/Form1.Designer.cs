namespace TestDemo
{
    partial class IndexForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PassWordtxt = new System.Windows.Forms.TextBox();
            this.UserIdtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PassWordtxt);
            this.panel1.Controls.Add(this.UserIdtxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RegisterBtn);
            this.panel1.Controls.Add(this.SignInBtn);
            this.panel1.Location = new System.Drawing.Point(71, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 253);
            this.panel1.TabIndex = 0;
            // 
            // PassWordtxt
            // 
            this.PassWordtxt.Location = new System.Drawing.Point(64, 138);
            this.PassWordtxt.Name = "PassWordtxt";
            this.PassWordtxt.PasswordChar = '*';
            this.PassWordtxt.Size = new System.Drawing.Size(138, 21);
            this.PassWordtxt.TabIndex = 5;
            // 
            // UserIdtxt
            // 
            this.UserIdtxt.Location = new System.Drawing.Point(64, 70);
            this.UserIdtxt.Name = "UserIdtxt";
            this.UserIdtxt.Size = new System.Drawing.Size(138, 21);
            this.UserIdtxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(168, 187);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "注册";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(9, 187);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(75, 23);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.Text = "登录";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "还无账号，赶紧去注册哟！";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "IndexForm";
            this.Text = "简单测试";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IndexForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassWordtxt;
        private System.Windows.Forms.TextBox UserIdtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Label label3;
    }
}

