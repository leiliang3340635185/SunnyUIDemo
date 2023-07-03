using BLL;
using Common;
using Entity;
using IBLL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.SystemManage
{
    /// <summary>
    /// 用户表单
    /// </summary>
    public partial class UserForm : UIForm
    {
        private IUserBLL bll = new UserBLL();
        private UserPage parentPage = null;      
        private base_user curEntity = new base_user();
        private string oldAccount = ""; //旧账号
        public UserForm(UserPage userPage)
        {
            InitializeComponent();
            this.parentPage = userPage;
            this.MaximizeBox = false;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (PublicData.UserInfo.status == "1")
                {

                }
                else if (PublicData.UserInfo.status == "2")
                {
                    curEntity= bll.GetEntity(PublicData.UserInfo.id);
                    txtAccount.Text = curEntity.account;
                    txtRealName.Text = curEntity.realname;
                    txtPassword.Text = curEntity.password;
                    txtPassword.Text = EncryptDecrypt.DecryptDES(curEntity.password,PublicData.Variable.EncryptKey);
                    cbxGender.Text = curEntity.gender;                   
                    dpBirthday.Text = curEntity.birthday==null?"" : curEntity.birthday.Value.ToString("yyyy-MM-dd");
                    txtEmail.Text = curEntity.email;
                    //旧账号
                    oldAccount = curEntity.account; 
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //验证数据
                if (!VerifyData())
                {
                    return;
                }
                //保存数据
                string account = txtAccount.Text.Trim();
                string realname = txtRealName.Text.Trim();
                string password = txtPassword.Text.Trim();
                password = EncryptDecrypt.EncryptDES(password, PublicData.Variable.EncryptKey); //加密
                string gender = cbxGender.Text.Trim();
                string birthday = dpBirthday.Text.Trim();
                string email = txtEmail.Text.Trim();
                if (PublicData.UserInfo.status == "1")
                {
                    curEntity.userid = Guid.NewGuid().ToString().Replace("-", "");
                    curEntity.delete_mark = 0;
                    curEntity.create_time = DateTime.Now;
                }
                else if(PublicData.UserInfo.status == "2")
                {
                    curEntity.update_time = DateTime.Now;
                }
                curEntity.account = account;
                curEntity.realname = realname;
                curEntity.password = password;
                curEntity.gender = gender;
                if (!string.IsNullOrEmpty(birthday))
                {
                    curEntity.birthday = DateTime.Parse(birthday);
                }
                else
                {
                    curEntity.birthday = null;
                }
                curEntity.email = email;
                if (PublicData.UserInfo.status == "1")
                {
                    bll.Add(curEntity);
                                        
                }
                else if (PublicData.UserInfo.status == "2")
                {
                    bll.Update(curEntity);
                }
                ShowInfoTip("保存成功!");
                this.Close();
                parentPage.RefreshData();
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());               
            }
        }
        /// <summary>
        /// 验证数据是否有效
        /// </summary>
        /// <returns></returns>
        private bool VerifyData()
        {
            bool result = true;
            string account = txtAccount.Text.Trim();
            string realname = txtRealName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(account))
            {
                ShowWarningDialog("账号不能为空!");
                result = false;
                return result;
            }
            if (string.IsNullOrEmpty(realname))
            {
                ShowWarningDialog("姓名不能为空!");
                result = false;
                return result;
            }
            if (string.IsNullOrEmpty(password))
            {
                ShowWarningDialog("密码不能为空!");
                result = false;
                return result;
            }
            //账号必须唯一
            if (!bll.VerifyAccount(PublicData.UserInfo.status, oldAccount, account))
            {
                ShowWarningDialog("账号必须唯一!");
                result = false;
                return result;
            }

            return result;
        }
    }
}
