using AD.Core.DepartMentManager.DepartMent.DepartManagerWindow;
using AD.CoreCommon.DataModel.ClientData;
using GameLog.LogHelper;
using Sunny.UI;
using System;

namespace AD.Core.DepartMentManager .DepartMentManagerWindowSys
{
    public class PersonDepartMentManagerWindowSys
    {
        public static PersonDepartMentManagerWindowSys Instance;
        protected PersonDepartMentManagerWindow PersonDepartMentManagerWindow = null;
        private IFreeSql freeSql = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departName"></param>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="isPhone"></param>
        /// <param name="_freeSql"></param>
        public void ShowPersonDepartMentManagerWindowSys(string departName, string acc, string pass, bool isPhone, IFreeSql _freeSql)
        {
            freeSql = _freeSql;
            PersonDepartMentManagerWindow = new PersonDepartMentManagerWindow();
            PersonDepartMentManagerWindow.DepartName = departName;
            PersonDepartMentManagerWindow.Password = pass;
            if(isPhone)
            {
                PersonDepartMentManagerWindow.Account = string.Empty;
                PersonDepartMentManagerWindow.Telphone = acc;
            }
            else
            {
                PersonDepartMentManagerWindow.Account = acc;
                PersonDepartMentManagerWindow.Telphone=string.Empty;
            }
            PersonDepartMentManagerWindow.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departName"></param>
        /// <param name="account"></param>
        /// <param name="telphone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DepartData LoadingPersonDepartManagerData(string departName, string account, string telphone, string password)
        {
            DepartData departData = new DepartData();
            try
            {
                if (string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(telphone))
                {
                    departData = freeSql.Select<DepartData>().Where(a => a.DepartName == departName && a.DepartMemberData.TelPhone == telphone && a.DepartMemberData.Password == password).ToOne();
                }
                else
                {
                    departData = freeSql.Select<DepartData>().Where(a => a.DepartName == departName && a.DepartMemberData.Account == account && a.DepartMemberData.Password == password).ToOne();
                }
                return departData;

            }
            catch(Exception ex)
            {
                LoggerHelper.Debug(ex);
                return null;
            }
        }
    }
}