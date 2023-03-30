using AD.CoreCommon.DataModel.ClientData;
using AD.CoreERP.Other.OtherManager.OtherManagerWindowSys;
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

namespace AD.CoreERP.Other_.OtherManager.OtherManagerWindow
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 账号信息
        /// </summary>
        public string account = string.Empty;
        /// <summary>
        /// 权限信息
        /// </summary>
        public  string password = string.Empty;
        RegisterTable registerTable = new RegisterTable(); 
        List<DepartMentData> departMentData = new List<DepartMentData>();
        List<DepartMentModel>departMentModels= new List<DepartMentModel>();
       // Bitmap bitmap;

        private void MainWindow_Load(object sender, EventArgs e)
        {
          
            Control.CheckForIllegalCrossThreadCalls = false;
            registerTable= MainWindowSys.Instance.LoadingInintdata(account, password);
            uiTabControl1.SelectedIndex = 0;

        }
        private void uiTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(uiTabControl1.SelectedIndex == 0)
            {
                if (registerTable == null) return;
                else
                {
                   
                    departMentModels = MainWindowSys.Instance.LoadingDepartMentData();
                    if (departMentModels.Count > 0)
                    {
                        foreach (var model in departMentModels)
                        {
                            uiComboBox3.Items.Add(model.departMentName);
                        }

                        MainWindowSys.Instance.ShowDepartMentDataView(ref departMentData, departMentModels, flowLayoutPanel1);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if(uiTabControl1.SelectedIndex == 1) 
            {
                if (registerTable != null)
                {
                    uiTextBox11.Text = registerTable.Account;
                    uiTextBox13.Text = registerTable.Password;
                    uiTextBox16.Text = registerTable.TelPhone;
                }
            }
        }

      
         

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string name = uiTextBox1.Text.Trim();
            string nowAddress = uiTextBox2.Text.Trim();
            string sex =uiComboBox1.Text.Trim();
            string familyAddress = uiTextBox3.Text.Trim();
            string IdPassword = uiTextBox4.Text.Trim();
            string emailAddress = uiTextBox5.Text.Trim();
            string depart = uiComboBox3.Text.Trim();
            string  sarly = uiComboBox2.Text.Trim();
            if(!string.IsNullOrEmpty(name)&&!string.IsNullOrEmpty(nowAddress)&& !string.IsNullOrEmpty(sex)&& !string.IsNullOrEmpty(familyAddress)&&!string.IsNullOrEmpty(IdPassword) && !string.IsNullOrEmpty(emailAddress) && !string.IsNullOrEmpty(depart) && !string.IsNullOrEmpty(sarly))
            {
                var sl = ImageHelper.ImageToBytes(bmp);
                if (RegexHelper.IsEmail(emailAddress))
                {
                    if (RegexHelper.IsIDCard(IdPassword)) 
                    {
                        RegisterTable userData = new RegisterTable()
                        {
                            Account = registerTable.Account,
                            TelPhone = registerTable.TelPhone,
                            Department = depart,
                            familyAddress = familyAddress,
                            NowAddress = nowAddress,
                            Email = emailAddress,
                            PersonIDCard = int.Parse(IdPassword),
                            SalaryData = sarly,
                            Password = registerTable.Password,
                            HandleState = 1,
                            PersonPicture = sl,

                        };
                        if (MainWindowSys.Instance.InsertDataToRegister(userData))
                        {
                            UIMessageBox.ShowSuccess("保存成功");
                            if (MessageBox.Show("是否清空全部数据", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                ClearAllData();
                            }
                            return;
                        }
                        else
                        {
                            UIMessageBox.ShowError("保存失败！！");
                            return;

                        }
                    }
                    else
                    {
                        UIMessageBox.ShowWarning("请输入一个有效的身份证信息！！");
                        return;
                    }
                }
                else
                {
                    UIMessageBox.ShowWarning("请输入一个可用的邮箱地址！！");
                    uiTextBox5.Text= string.Empty;
                    return;
                }
            }
            else
            {
                UIMessageBox.ShowError("请将信息填写完整");
                return;
            }
        }

        private void ClearAllData()
        {
            uiTextBox1.Text= string.Empty;
            uiTextBox2.Text= string.Empty;
            uiTextBox3.Text =string.Empty;
            uiTextBox4.Text=string.Empty;
            uiTextBox5.Text=string.Empty;
            pictureBox1.Image = null;
            bmp = null;
            uiComboBox1.Text= string.Empty;
            uiComboBox3.Text= string.Empty;
            uiComboBox2.Text= string.Empty; 
            


        }
        Bitmap bmp= null;   
       

   
        private void uiButton2_Click(object sender, EventArgs e)
        {
            string path = MainWindowSys.Instance.OpenChooseLocalImageFile();
            if (!string.IsNullOrEmpty(path))
            {
                bmp= (Bitmap)Image.FromFile(path);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = bmp;
            }
            else
            {
                return;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image= null;
            bmp = null;
            string path = MainWindowSys.Instance.OpenChooseLocalImageFile();
            if (!string.IsNullOrEmpty(path))
            {
                bmp = (Bitmap)Image.FromFile(path);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = bmp;
            }
            else
            {
                return;
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            var account = uiTextBox12.Text.Trim();
            var pass = uiTextBox14.Text.Trim();
            var passs = uiTextBox15.Text.Trim();
            var tel = uiTextBox17.Text.Trim();
            var aTEL = uiTextBox18.Text.Trim();
            if (!string.IsNullOrEmpty(account)&&!string.IsNullOrEmpty(pass)&&!string.IsNullOrEmpty(passs)&&!string.IsNullOrEmpty(tel)&&!string.IsNullOrEmpty(aTEL))
            {
                if (pass==passs)
                {
                    if (tel == aTEL)
                    {
                        MainWindowSys.Instance.ChangePersonData(registerTable, account, pass, tel);
                    }
                }
            }
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            ClearData();
            if (registerTable != null)
            {
                uiTextBox11.Text = registerTable.Account;
                uiTextBox13.Text = registerTable.Password;
                uiTextBox16.Text = registerTable.TelPhone;
            }
        }

        private void ClearData()
        {
            uiTextBox12.Text = string.Empty;
            uiTextBox14.Text = string.Empty;
            uiTextBox15.Text = string.Empty;
            uiTextBox17.Text = string.Empty;
            uiTextBox18.Text = string.Empty;
        }
    }
}
