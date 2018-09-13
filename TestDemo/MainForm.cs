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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label2.Visible = false;//提示输入消息用以发送信息
        }
        public int a = 0;
        public string UserId = "";
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            if (!string.IsNullOrEmpty(UserId))
            {
                this.label1.Text = "欢迎您："+UserId;
                a = 2;
                using (var db = new TestDemoWinFormEntities())
                {
                    var dbData = db.ViewFriendRelation.AsQueryable();
                    dbData = dbData.Where(c => c.UserId == UserId && c.Deleted!=1);
                    dataGridView1.DataSource = dbData.ToList();
                }
            }
            else
            {
                this.label1.Text = "请登录!";
                a = 1;
            }
        }
        /// <summary>
        /// 发表看法按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PublishBtn_Click(object sender, EventArgs e)
        {

            var sendmsg = this.sendMsgRichTextBox.Text;
            if(sendmsg=="")
            {
                label2.Visible = true;
                label2.Text = "信息不能为空";
            }
            else
            {
                label2.Visible = false;
                using (var db=new TestDemoWinFormEntities())
                {                    
                    var datalist = db.Log_UserMsg.AsQueryable();
                    int a = int.Parse(LogUserMsg.GetTransId(UserId));
                    var dataMsgList = new Bus_SendMsg();
                    dataMsgList.SendUserId = a;
                    dataMsgList.SendMsg = UserId + ":" + this.sendMsgRichTextBox.Text;
                    dataMsgList.SendTime = DateTime.Now;
                    db.Bus_SendMsg.Add(dataMsgList);
                    db.SaveChanges();
                }
                this.MainMsgRichTextBox.Text += "***********" + DateTime.Now + "***********"+"\n";
                this.MainMsgRichTextBox.Text += UserId + ":" + this.sendMsgRichTextBox.Text+"\n";
                this.sendMsgRichTextBox.Text = "";
            }
        }
        /// <summary>
        /// 返回至登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BackToSignBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            IndexForm indform = new IndexForm();
            indform.Show();
        }
        /// <summary>
        /// 根据搜索条件去找人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            var searchtxt = this.SearchUserIdtxt.Text.Trim();
            if(!string.IsNullOrEmpty(searchtxt))
            {
                using (var db=new TestDemoWinFormEntities())
                {
                    ErrorProvider erp = new ErrorProvider();
                    var dbData = db.ViewFriendRelation.AsQueryable();
                    dbData = dbData.Where(c => c.UserId == UserId && c.FriendUserId==searchtxt);
                    if(dbData.Count()!=0)
                    {
                        erp.SetError(SearchUserIdtxt, null);
                        var dbDatalist = db.Log_UserMsg.AsQueryable();
                        dbDatalist = dbDatalist.Where(c=>c.UserId==searchtxt);
                        dataGridView1.DataSource = dbDatalist.ToList();
                    }
                    else
                    {
                        erp.SetError(SearchUserIdtxt, "该用户还不是你的好友");
                    }                      
                }
            }
        }
        /// <summary>
        /// 添加 
        /// 先进行查询是否存在该用户
        /// 然后再判断是否已经添加该用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewFriendBtn_Click(object sender, EventArgs e)
        {
            ErrorProvider erp = new ErrorProvider();
            dataGridView1.ReadOnly = true;
            var searchtxt = this.SearchUserIdtxt.Text.Trim();
            using (var db = new TestDemoWinFormEntities())
            {
                //检查用户是否存在
                var checkUserId = db.Log_UserMsg.AsQueryable();
                checkUserId = checkUserId.Where(c => c.UserId== searchtxt);
                if(checkUserId.Count()==0)
                {
                    erp.SetError(SearchUserIdtxt,"该用户不存在，请重新输入");
                }
                else
                {
                    erp.SetError(SearchUserIdtxt, null);
                    //检查是否已经是我的好友
                    var transId = db.Proc_GetTransId(UserId).First().ToString();
                    int temp = int.Parse(transId);
                    var checkfriendRelation = db.Rla_FriendRelation.AsQueryable();
                    checkfriendRelation = checkfriendRelation.Where(c => c.UserId==searchtxt && c.ParentUserTransId == temp);
                    if(checkfriendRelation.Count()==0)
                    {
                        erp.SetError(SearchUserIdtxt, null);
                        var datalist = new Rla_FriendRelation();
                        datalist.UserId = searchtxt;
                        datalist.ParentUserTransId = int.Parse(transId);
                        datalist.Deleted = 0;
                        db.Rla_FriendRelation.Add(datalist);
                        db.SaveChanges();
                        MessageBox.Show("添加成功", "温馨提示");
                        var dbData = db.ViewFriendRelation.AsQueryable();
                        dbData = dbData.Where(c => c.UserId == UserId && c.Deleted != 1);
                        dataGridView1.DataSource = dbData.ToList();
                        SearchUserIdtxt.Text = "";
                        erp.SetError(SearchUserIdtxt, "");
                    }
                    else
                    {                     
                        erp.SetError(SearchUserIdtxt, "该用户您已经添加为好友，请勿重复添加");
                    }
                }  
            }
        }
    }
}
