using BLL;
using Common;
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
    [DataFormAttribute(Description = "授权管理")]
    public partial class AuthorizeManagePage : UIPage
    {

        /// <summary>
        /// 授权类型
        /// </summary>
        private AuthorizeTypeEnum authorizeType;
        private IUserBLL userbll = new UserBLL();
        private IRoleBLL rolebll = new RoleBLL();
        DataTable data = new DataTable();
        public AuthorizeManagePage()
        {
            InitializeComponent();
            dg.AutoGenerateColumns = false;
        }
        
        private void AuthorizeManagePage_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }
        /// <summary>
        /// 查询
        /// </summary>
        private void Query()
        {
            try
            {
                string strAuthorizeType = cbxAuthorizeType.Text.Trim();
                if (string.IsNullOrEmpty(strAuthorizeType))
                {
                    ShowErrorDialog("授权类型不能为空!");
                    return;
                }
                if (strAuthorizeType == "用户")
                {
                    authorizeType = AuthorizeTypeEnum.User;
                }
                else if (strAuthorizeType == "角色")
                {
                    authorizeType = AuthorizeTypeEnum.Role;
                }
                string keyword = txtKeyword.Text.Trim();
                if (authorizeType == AuthorizeTypeEnum.Role)
                {
                    data = rolebll.GetTable();
                }
                else if (authorizeType == AuthorizeTypeEnum.User)
                {
                    data = userbll.GetTable();
                }
            }
            catch (Exception ex)
            {
                ShowErrorDialog(ex.ToString());
            }
        }
        private void cbxAuthorizeType_SelectedValueChanged(object sender, EventArgs e)
        {
            UIComboBox combobox=(UIComboBox)sender;
                        
        }
    }
}
