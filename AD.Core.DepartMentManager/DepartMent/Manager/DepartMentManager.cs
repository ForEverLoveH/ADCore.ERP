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
                    if (sl.DepartMemberData.IsDepartManager)
                    {
                        ShowDepartMentManagerWindow(departName);
                    }
                    else
                    {
                        //根据小组 名单，判断是否是组长
                    }
                }
            }
            
        }

        private void ShowDepartMentManagerWindow(string departName)
        {
            switch (departName)
            {
                case "人事部":
                    
                    break;
                case "销售部" :
                    
                    break;
                case "开发部":
                    
                    break;
                case  "后勤部":
                    
                    break;
                    

            }
        }
    }
}