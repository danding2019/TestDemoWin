using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDemo
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rgf = new RegisterForm();
            rgf.Show();
        }
        public  int a = 0;
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var UserIdString = this.UserIdtxt.Text.Trim();
            var PassWordString = this.PassWordtxt.Text.Trim();
            if(!string.IsNullOrEmpty(UserIdString) && !string.IsNullOrEmpty(PassWordString))
            {
                using (var db = new TestDemoWinFormEntities())
                {
                    var dbData = db.Log_UserMsg.AsQueryable();
                    dbData = dbData.Where(c => c.UserId == UserIdString);
                    a++;
                    if(dbData.Count()!=0)
                    {
                        dbData = dbData.Where(c => c.PassWord == PassWordString);
                        if(dbData.Count()!=0)
                        {
                            
                            this.Hide();
                            MainForm mf = new MainForm();
                            mf.UserId = UserIdString;
                            mf.Show();
                        }
                        else if(dbData.Count() == 0 && a<3)
                        {
                            MessageBox.Show("密码错误！请重新输入", "登录失败");
                            this.PassWordtxt.Text = "";
                        }
                    }
                    if(a>=3)
                    {
                        MessageBox.Show("密码错误！请联系管理员找回密码", "登录失败");
                        this.PassWordtxt.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("请填写完整", "登录失败");
            }
            
        }
       

        private void IndexForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignInBtn_Click(sender, e);
            }
        }
    }
}
