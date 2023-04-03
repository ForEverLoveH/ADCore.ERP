using System.Security.Permissions;
using AD.Core.DepartMentManager.DepartMent.DepartManagerWindow;

namespace AD.Core.DepartMentManager.DepartMentManagerWindowSys
{
    public class FinanceDepartmentManagerWindowSys
    {
        public static FinanceDepartmentManagerWindowSys Instance;
        private FinanceDepartmentManagerWindow FinanceDepartmentManagerWindow = null;
        private IFreeSql _freeSql = null;

        public void Awake()
        {
            Instance = this;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departName"></param>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="isPhone"></param>
        /// <param name="freeSql"></param>
        public void ShowFinanceDepartmentManagerWindow(string departName, string acc, string pass, bool isPhone, IFreeSql freeSql)
        {
            
        }
    }
}