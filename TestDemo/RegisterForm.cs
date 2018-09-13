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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void CheckRegisterBtn_Click(object sender, EventArgs e)
        {
            var UserIdString= this.UserIdtxt.Text.Trim();
            var PassWordString = this.PassWordtxt.Text.Trim();
            var PassWordStringRe = this.PassWordtxt2.Text.Trim();
            var MobileNumString = this.MobileNumtxt.Text.Trim();
            if (!string.IsNullOrEmpty(UserIdString)&& !string.IsNullOrEmpty(PassWordString) && !string.IsNullOrEmpty(PassWordStringRe) && !string.IsNullOrEmpty(MobileNumString))
            {
                if(!PassWordString.Equals( PassWordStringRe))
                {
                    MessageBox.Show("密码输入不相同，请重新输入","温馨提示");
                }
                else
                {
                    using (var db=new TestDemoWinFormEntities())
                    {
                        var dbData = db.Log_UserMsg.AsQueryable();
                        dbData = dbData.Where(c => c.UserId == UserIdString && c.MobileNum== MobileNumString);
                        if (dbData.Count() == 0)
                        {
                            var datalist = new Log_UserMsg();
                            datalist.UserId = UserIdString;
                            datalist.PassWord = PassWordString;
                            datalist.MobileNum = MobileNumString;
                            datalist.CreateTime = DateTime.Now;
                            db.Log_UserMsg.Add(datalist);
                            db.SaveChanges();
                            MessageBox.Show( "恭喜你注册成功！", "成功提示");
                            this.UserIdtxt.Text="";
                            this.PassWordtxt.Text="";
                            this.PassWordtxt2.Text="";
                            this.MobileNumtxt.Text="";
                        }
                        else if(dbData.Count() != 0)
                        {
                            MessageBox.Show( "该账号已被注册！","错误提示");
                        }
                        else
                        {
                            MessageBox.Show( "该手机号已被注册！","错误提示");
                        }
                    }                                                                          
                }
            }
            else
            {
                MessageBox.Show("请填写完整!","温馨提示");
            }
        }

        private void RebackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm iF = new IndexForm();      
            iF.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void MobileNumtxt_Validated(object sender, EventArgs e)
        {
            ErrorProvider errorp = new ErrorProvider();
            if (string.IsNullOrEmpty(this.MobileNumtxt.Text.Trim()))
            {
                errorp.SetError(MobileNumtxt,"此处不允许为空");
            }
            else
            {
                var PhoneCheckStr = MobileNumtxt.Text.Trim();

            }
        }
    }
}
