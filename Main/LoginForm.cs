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
    public partial class LoginForm : UILoginForm
    {
        private IUserBLL userbll = new UserBLL();
        public LoginForm()
        {
            InitializeComponent();
            LoginImage = UILoginImage.Login6;

            ButtonLoginClick += LoginForm_ButtonLoginClick;
            ButtonCancelClick += LoginForm_ButtonCancelClick;
            OnLogin += LoginForm_OnLogin;

            UserName = "admin";
            Password = "123";

            
        }

       

       
        /// <summary>
        /// 确定按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_ButtonLoginClick(object sender, EventArgs e)
        {
            Login();
        }
        /// <summary>
        /// 登录
        /// </summary>
        private void Login()
        {
            try
            {
                if (string.IsNullOrEmpty(UserName))
                {
                    ShowWarningDialog("用户名不能为空!");
                    return;
                }
                if (string.IsNullOrEmpty(Password))
                {
                    ShowWarningDialog("密码不能为空!");
                    return;
                }
                Password = EncryptDecrypt.EncryptDES(Password, PublicData.Variable.EncryptKey);
                base_user entity = userbll.Login(UserName, Password);
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
        /// 取消按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool LoginForm_OnLogin(string userName, string password)
        {
            return false;
        }
    }
}
