using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD.CoreCommon.DataModel.ClientData;
using AD.CoreERP.AD.CoreClientSystem.AD.CoreWindowSys;
using AD.CoreERP.AD.CoreWindowSys;
using Sunny.UI;

namespace AD.CoreERP.AD.CoreClientSystem.AD.CoreWindow
{
    public partial class RigisterWindow : Form
    {
        public RigisterWindow()
        {
            InitializeComponent();
        }
        ImageCode ImageCode = new ImageCode();
        private const int ImageVeriCodeLength = 4;//验证码长度        
        private String strImageVeriCode = "";//验证码
        /// <summary>
        ///  保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
         {
             string acc = uiTextBox1.Text.Trim();
             string pass = uiTextBox2.Text.Trim();
             string repass = uiTextBox4.Text.Trim();
             string telPhone = uiTextBox3.Text.Trim();
             string ImageCodeStr = uiTextBox5.Text.Trim();
            // string po = uiComboBox1.Text.Trim();
             if (!string.IsNullOrEmpty(acc) && !string.IsNullOrEmpty(pass) && !string.IsNullOrEmpty(repass) &&
                 !string.IsNullOrEmpty(telPhone)&&!string.IsNullOrEmpty(ImageCodeStr) )
             {
                if (RegexHelper.CheckMobilePhone(telPhone))
                {
                    if (strImageVeriCode.ToLower() == ImageCodeStr || strImageVeriCode.ToUpper() == ImageCodeStr)
                    {
                        if (pass == repass)
                        {

                            bool sl = RigisterWindowSys.Instance.SaveDataToDataBase(acc, pass, telPhone);
                            if (sl)
                            {
                                UIMessageBox.ShowSuccess("注册成功");
                                if (MessageBox.Show("是否前往登录?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    Hide();
                                    LoginWindowSys.Instance.ShowLoginWindow();
                                }
                            }
                            else
                            {
                                UIMessageBox.ShowError("注册失败！！");
                                UIMessageBox.ShowWarning("请检查信息是否填写完整！！");
                                UpDataImageCode();
                                return;
                            }
                        }
                    }
                    else
                    {
                        UIMessageBox.ShowError("图片验证码不一致,请重新输入!!");
                        UpDataImageCode();
                        uiTextBox5.Text = string.Empty;
                        return;
                    }
                }
             }
         }

        private void RigisterWindow_Load(object sender, EventArgs e)
        {
            UpDataImageCode();
        }

        private void UpDataImageCode()
        {
            strImageVeriCode = ImageCode.CreateRandomImageCode(ImageVeriCodeLength);//生成随机验证码
            if (strImageVeriCode == "") return;
            ImageCode.CreateImageCodeBackGroup(strImageVeriCode, pictureBox1);//创建验证码图片
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpDataImageCode();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
