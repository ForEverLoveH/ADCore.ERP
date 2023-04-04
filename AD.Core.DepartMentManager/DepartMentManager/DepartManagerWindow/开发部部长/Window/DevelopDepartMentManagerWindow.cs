using System;
using System.Windows.Forms;
using AD.Core.DepartMentManager.DepartMentManagerWindowSys;
using AD.CoreCommon.DataModel.ClientData;

namespace AD.Core.DepartMentManager.DepartMent.DepartManagerWindow
{
    public partial class DevelopDepartMentManagerWindow : Form
    {
        public DevelopDepartMentManagerWindow()
        {
            InitializeComponent();
        }
        public  string Account { get; set; }
        public string DepartName { get; set; }
        public string Telphone { get; set; }
        public string Password { get; set; }
       
        private DepartData DepartDatas;

        private void DevelopDepartMentManagerWindow_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            DepartDatas =  DevelopDepartMentManagerWindowSys.Instance.LoadingDevelopDepartMentData(DepartName,Account, Telphone, Password );
        }
    }
}