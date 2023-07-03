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

namespace Main
{
    public partial class LoginForm2 : UIForm
    {
        private IUserBLL userbll = new UserBLL();
        public LoginForm2()
        {
            InitializeComponent();

            edtUser.Text = "admin";
            edtPassword.Text = "123";
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 登录
        /// </summary>
        private void Login()
        {
            try
            {
                string account = edtUser.Text.Trim();
                string password = edtPassword.Text.Trim();
                if (string.IsNullOrEmpty(account))
                {
                    ShowWarningDialog("账号不能为空!");
                    return;
                }
                if (string.IsNullOrEmpty(password))
                {
                    ShowWarningDialog("密码不能为空!");
                    return;
                }
                password = EncryptDecrypt.EncryptDES(password, PublicData.Variable.EncryptKey);
                base_user entity = userbll.Login(account, password);
                //保存当前登录用户
                PublicData.Variable.IsLogin = true;
                PublicData.LoginInfo.id = entity.userid;
                PublicData.LoginInfo.account = entity.account;
                PublicData.LoginInfo.realname = entity.realname;
                //关闭登录窗口，显示主窗体
                this.Close();

            }
            catch (Exception ex)
            {

                ShowErrorDialog(ex.Message);
            }
        }
        /// <summary>
        /// 密码输入框回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
