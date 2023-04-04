using AD.Core.DepartMentManager.DepartMentManagerWindowSys;
using AD.CoreCommon.DataModel.ClientData;
using System.Windows.Forms;

namespace AD.Core.DepartMentManager.DepartMent.DepartManagerWindow
{
    public partial class PersonDepartMentManagerWindow : Form
    {
        public string DepartName { get; internal set; }
        public string Password { get; internal set; }
        public string Account { get; internal set; }
        public string Telphone { get; internal set; }

        public PersonDepartMentManagerWindow()
        {
            InitializeComponent();
        }
        DepartData departData = new DepartData();
        
        private void ucNavigationMenu1_ClickItemed(object sender, System.EventArgs e)
        {
            var sl = ucNavigationMenu1.SelectItem;
            if (sl != null)
            {
                var txt = sl.Text.Trim();
                if (!string.IsNullOrEmpty(txt))
                {
                    switch (txt)
                    {
                        case "任务管理"://主要是负责接收来自工厂管理者的任务，以及分配日 月 任务给各个小组

                            break;
                        case "面试系统": //主要是负责接收和分配面试任务给各组

                            break;
                        case "上传系统": //主要是将面试结果根据部门关系，上传给各个部门部长

                            break;
                        case "成员管理": //成员管理系统

                            break;
                        case "雇佣系统": //主要是处理在面试完成之后，将人员名单上传给各个部门之后的反馈

                            break;
                    }
                }
                else
                    return;

            }
            else
                return;
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (uiTabControl1.SelectedIndex == 0)
            {
                 
            }
            if(uiTabControl1.SelectedIndex == 1)
            {

            }
        }

        private void PersonDepartMentManagerWindow_Load(object sender, System.EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            departData = PersonDepartMentManagerWindowSys.Instance.LoadingPersonDepartManagerData(DepartName, Account, Telphone, Password);
            uiTabControl1.SelectedIndex = 0;
        }
    }
}