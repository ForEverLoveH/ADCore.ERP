using AD.Core.DepartMentManager.DepartMentManagerWindowSys;
using AD.CoreCommon.DataModel.ClientData;

namespace AD.Core.DepartMentManager
{
    public class DepartMentManager
    {
        public static DepartMentManager Instance;
        private IFreeSql _freeSql;
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
        /// <param name="freeSql"></param>
        /// <param name="isPhone"></param>
        public void  ShowDepartMentWindow(string departName, string acc, string pass, IFreeSql freeSql, bool isPhone)
        {
            _freeSql = freeSql;
            if (isPhone)
            {
                var sl = _freeSql.Select<DepartData>().Where(a => a.DepartName == departName && a.DepartMemberData.TelPhone == acc && a.DepartMemberData.Password == pass).ToOne();
                if (sl != null)
                {
                    if (sl.DepartMemberData.IsDepartManager )
                    {
                        ShowDepartMentManagerWindow(departName,acc,pass,isPhone);
                    }
                    else
                    {
                        //根据小组 名单，判断是否是组长
                        
                    }
                }
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departName"></param>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="isPhone"></param>
        private void ShowDepartMentManagerWindow(string departName,string acc ,string pass,bool isPhone)
        {
            switch (departName)
            {
                case "人事部":
                    PersonDepartMentManagerWindowSys.Instance.ShowPersonDepartMentManagerWindowSys(departName, acc,
                        pass, isPhone, _freeSql);
                    break;
                case "销售部" :
                    MarketDepartMentManagerWindowSys.Instance.ShowMarketDepartMentManagerWindowSys(departName, acc,
                        pass, isPhone, _freeSql);
                    break;
                case "开发部":
                    DevelopDepartMentManagerWindowSys.Instance.ShowDevelopDepartMentManagerWindowSys(departName, acc,
                        pass, isPhone, _freeSql);
                    break;
                case  "后勤部":
                    LogisticsDepartmentManagerWindowSys.Instance.ShowLogisticsDepartmentManagerWindow(departName, acc,
                        pass, isPhone, _freeSql);
                    break;
                case "财务部":
                    FinanceDepartmentManagerWindowSys.Instance.ShowFinanceDepartmentManagerWindow(departName, acc, pass,
                        isPhone, _freeSql);
                    break;
                    

            }
        }
    }
}