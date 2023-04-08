 
using AD.CoreERP.AD.CoreClientSystem;
using AD.CoreERP.AD.CoreWindowSys;
using AD.CoreERP.FactoryManager.FactoryManager.FactoryManagerWindow;
using HZH_Controls.Forms;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using AD.Core.DepartMentManager;
using AD.CoreCommon.DataModel.ClientData;

namespace AD.CoreERP.AD.CoreWindow
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
       
        private const int ImageVeriCodeLength = 4;//验证码长度        
        private String strImageVeriCode = "";//验证码
        ImageCode imageCode = new ImageCode();
        private void uiButton1_Click(object sender, EventArgs e)
        {
            string acc = uiTextBox1.Text.Trim();
            string pass = uiTextBox2.Text.Trim();
            LoginGame(acc, pass);
        }

        private void LoginGame(string acc ,string pass)
        {
             
            if (!string.IsNullOrEmpty(acc )&&!string.IsNullOrEmpty(pass))
            {
                int sl=-2;
                bool IsPhone = RegexHelper.CheckMobilePhone(acc);
                if (IsPhone)
                {
                    sl  = LoginWindowSys.Instance.LoginGameByPhoneNumber(acc, pass);
                }
                else
                {
                    sl = LoginWindowSys.Instance.LoginGameByAccount(acc, pass);
                }

                if (sl==0)
                {
                    UIMessageBox.ShowWarning("请完善你的身份信息");
                    LoginWindowSys.Instance.ShowOtherFactoryPersonWindow(acc, pass);
                }
                else if (sl == -1)
                {
                    
                }
                else if (sl == 1)
                {
                    if (LoginWindowSys.Instance.SelectCurrentLoginMessageFactoryManager(acc, pass, IsPhone))
                    {
                        
                    }
                    else
                    {
                        string departName = LoginWindowSys.Instance.SelectCurrentLoginMessageDepartMentData(acc, pass, IsPhone );
                        if (!string.IsNullOrEmpty(departName))
                        {
                            LoginWindowSys.Instance.ShowDepartMentWindow(departName, acc, pass,IsPhone);

                        }
                    }
                    
                }
                else if(sl == 2)
                {
                    UIMessageBox.ShowWarning("当前你的请求正在处理中，请等待！！");
                    Application.Exit();
                    return;
                }

            }
            else
            {
                FrmTips.ShowTipsInfo(this, "请将正好或者密码填写完整！！");return;
            }
        }
        
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            LoginWindowSys.Instance.ToRegisterWindow();
        }
 
        
        /// <summary>
        /// 更新图片验证码
        /// </summary>
        private void UpdateImageVeriCode()
        {
            strImageVeriCode = imageCode.CreateRandomImageCode(ImageVeriCodeLength);//生成随机验证码
            if (strImageVeriCode == "") return;
            imageCode.CreateImageCodeBackGroup(strImageVeriCode, pictureBox1);//创建验证码图片
        }
 
         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiTabControl1.SelectedIndex == 1)
            {
                UpdateImageVeriCode();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginWindow_Load(object sender, EventArgs e)
        {
            uiTabControl1.SelectedIndex= 0;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateImageVeriCode();
        }
        
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton4_Click(object sender, EventArgs e)
        {
            var imageStr = uiTextBox4.Text.Trim();
            var acc = uiTextBox3.Text.Trim();
            var pass=uiTextBox5.Text.Trim();
            if(!string.IsNullOrEmpty(imageStr)&&!string.IsNullOrEmpty(acc)&&!string.IsNullOrEmpty(pass))
            {
                 LoginGame(acc, pass);  
            }
            else
            {
                FrmTips.ShowTipsWarning(this, "请确定登录信息的完整！");
                UpdateImageVeriCode();
                return;
            }
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            LoginWindowSys.Instance.ToRegisterWindow();
        }

         
    }
}
