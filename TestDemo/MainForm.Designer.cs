namespace TestDemo
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.sendMsgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.MainMsgRichTextBox = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.PublishBtn = new System.Windows.Forms.Button();
            this.BackToSignBtn = new System.Windows.Forms.Button();
            this.AddNewFriendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowFirendviewlist = new System.Windows.Forms.ListView();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchUserIdtxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.sendMsgRichTextBox);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.MainMsgRichTextBox);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.PublishBtn);
            this.panel1.Location = new System.Drawing.Point(32, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 491);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // sendMsgRichTextBox
            // 
            this.sendMsgRichTextBox.Location = new System.Drawing.Point(52, 253);
            this.sendMsgRichTextBox.Name = "sendMsgRichTextBox";
            this.sendMsgRichTextBox.Size = new System.Drawing.Size(489, 96);
            this.sendMsgRichTextBox.TabIndex = 1;
            this.sendMsgRichTextBox.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainMsgRichTextBox
            // 
            this.MainMsgRichTextBox.Location = new System.Drawing.Point(52, 20);
            this.MainMsgRichTextBox.Name = "MainMsgRichTextBox";
            this.MainMsgRichTextBox.Size = new System.Drawing.Size(489, 226);
            this.MainMsgRichTextBox.TabIndex = 0;
            this.MainMsgRichTextBox.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(76, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // PublishBtn
            // 
            this.PublishBtn.Location = new System.Drawing.Point(466, 367);
            this.PublishBtn.Name = "PublishBtn";
            this.PublishBtn.Size = new System.Drawing.Size(75, 23);
            this.PublishBtn.TabIndex = 1;
            this.PublishBtn.Text = "发表看法";
            this.PublishBtn.UseVisualStyleBackColor = true;
            this.PublishBtn.Click += new System.EventHandler(this.PublishBtn_Click);
            // 
            // BackToSignBtn
            // 
            this.BackToSignBtn.Location = new System.Drawing.Point(1072, 8);
            this.BackToSignBtn.Name = "BackToSignBtn";
            this.BackToSignBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToSignBtn.TabIndex = 2;
            this.BackToSignBtn.Text = "注销";
            this.BackToSignBtn.UseVisualStyleBackColor = true;
            this.BackToSignBtn.Click += new System.EventHandler(this.BackToSignBtn_Click);
            // 
            // AddNewFriendBtn
            // 
            this.AddNewFriendBtn.Location = new System.Drawing.Point(213, 45);
            this.AddNewFriendBtn.Name = "AddNewFriendBtn";
            this.AddNewFriendBtn.Size = new System.Drawing.Size(75, 23);
            this.AddNewFriendBtn.TabIndex = 3;
            this.AddNewFriendBtn.Text = "添加";
            this.AddNewFriendBtn.UseVisualStyleBackColor = true;
            this.AddNewFriendBtn.Click += new System.EventHandler(this.AddNewFriendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "请登录";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.ShowFirendviewlist);
            this.panel2.Controls.Add(this.SearchBtn);
            this.panel2.Controls.Add(this.AddNewFriendBtn);
            this.panel2.Controls.Add(this.SearchUserIdtxt);
            this.panel2.Location = new System.Drawing.Point(656, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 491);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(488, 266);
            this.dataGridView1.TabIndex = 4;
            // 
            // ShowFirendviewlist
            // 
            this.ShowFirendviewlist.Location = new System.Drawing.Point(0, 74);
            this.ShowFirendviewlist.Name = "ShowFirendviewlist";
            this.ShowFirendviewlist.Size = new System.Drawing.Size(494, 398);
            this.ShowFirendviewlist.TabIndex = 3;
            this.ShowFirendviewlist.UseCompatibleStateImageBehavior = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(213, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "搜索";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchUserIdtxt
            // 
            this.SearchUserIdtxt.Location = new System.Drawing.Point(3, 5);
            this.SearchUserIdtxt.Name = "SearchUserIdtxt";
            this.SearchUserIdtxt.Size = new System.Drawing.Size(147, 21);
            this.SearchUserIdtxt.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackToSignBtn);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PublishBtn;
        private System.Windows.Forms.Button BackToSignBtn;
        private System.Windows.Forms.Button AddNewFriendBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox sendMsgRichTextBox;
        private System.Windows.Forms.RichTextBox MainMsgRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView ShowFirendviewlist;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchUserIdtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}