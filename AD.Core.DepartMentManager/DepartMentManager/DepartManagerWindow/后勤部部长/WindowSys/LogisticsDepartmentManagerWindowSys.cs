using AD.Core.DepartMentManager.DepartMent.DepartManagerWindow;

namespace AD.Core.DepartMentManager.DepartMentManagerWindowSys
{
    public class LogisticsDepartmentManagerWindowSys
    {
        public static LogisticsDepartmentManagerWindowSys Instance;
        protected LogisticsDepartmentManagerWindow LogisticsDepartmentManagerWindow = null;
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
        public void ShowLogisticsDepartmentManagerWindow(string departName, string acc, string pass, bool isPhone, IFreeSql freeSql)
        {
            
        }
    }
}