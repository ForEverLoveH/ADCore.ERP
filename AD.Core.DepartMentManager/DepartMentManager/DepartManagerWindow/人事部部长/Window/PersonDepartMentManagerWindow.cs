using System.Windows.Forms;

namespace AD.Core.DepartMentManager.DepartMent.DepartManagerWindow
{
    public partial class PersonDepartMentManagerWindow : Form
    {
        public PersonDepartMentManagerWindow()
        {
            InitializeComponent();
        }

        private void ucNavigationMenu1_ClickItemed(object sender, System.EventArgs e)
        {
            var sl = ucNavigationMenu1.SelectItem;
            if (sl != null)
            {
                var txt = sl.Text.Trim();
                if (!string.IsNullOrEmpty(txt))
                {
                    switch(txt)
                    {
                        case "�������"://��Ҫ�Ǹ���������Թ��������ߵ������Լ������� �� ���������С��

                            break;
                        case "����ϵͳ": //��Ҫ�Ǹ�����պͷ����������������

                            break;
                        case "�ϴ�ϵͳ": //��Ҫ�ǽ����Խ�����ݲ��Ź�ϵ���ϴ����������Ų���

                            break;
                        case "��Ա����": //��Ա����ϵͳ

                            break;
                        case "��Ӷϵͳ": //��Ҫ�Ǵ������������֮�󣬽���Ա�����ϴ�����������֮��ķ���

                            break;
                    }
                }
            }
        }

        private void uiTabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void PersonDepartMentManagerWindow_Load(object sender, System.EventArgs e)
        {

        }
    }
}