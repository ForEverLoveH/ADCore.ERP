using System;
using AD.Core.DepartMentManager.DepartMent.DepartManagerWindow;
using AD.CoreCommon.DataModel.ClientData;
using GameLog.LogHelper;

namespace AD.Core.DepartMentManager.DepartMentManagerWindowSys
{
    public class DevelopDepartMentManagerWindowSys
    {
        public static DevelopDepartMentManagerWindowSys Instance;
        private DevelopDepartMentManagerWindow _developDepartMentManagerWindow = null;
        private IFreeSql freeSql = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departName"></param>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="isPhone"></param>
        /// <param name="freeSql1"></param>
        public void ShowDevelopDepartMentManagerWindowSys(string departName, string acc, string pass, bool isPhone, IFreeSql _freeSql)
        {
            freeSql = _freeSql;
            _developDepartMentManagerWindow = new DevelopDepartMentManagerWindow();
            _developDepartMentManagerWindow.DepartName = departName;
            if (isPhone)
            {
                _developDepartMentManagerWindow.Account = acc;
                _developDepartMentManagerWindow.Telphone = string.Empty;
            }
            else
            {
                _developDepartMentManagerWindow.Account = string.Empty;
                _developDepartMentManagerWindow.Telphone = pass;
            }
            _developDepartMentManagerWindow.Password = pass;
            _developDepartMentManagerWindow.Show();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="departName"></param>
        /// <param name="account"></param>
        /// <param name="telphone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public DepartData LoadingDevelopDepartMentData(string departName, string account, string telphone, string password)
        {
            try
            {
                DepartData departData =new DepartData();
                if (string.IsNullOrEmpty(account) && !string.IsNullOrEmpty(telphone))
                {
                    departData = freeSql.Select<DepartData>().Where(a =>
                        a.DepartName == departName && a.DepartMemberData.TelPhone == telphone &&
                        a.DepartMemberData.Password == password).ToOne();
                }
                else if(!string.IsNullOrEmpty(account)&& string.IsNullOrEmpty(telphone))
                {
                    departData = freeSql.Select<DepartData>().Where(a =>
                        a.DepartName == departName && a.DepartMemberData.Account == account &&
                        a.DepartMemberData.TelPhone == telphone).ToOne();
                }
                return departData;
            }
            catch (Exception e)
            {
               LoggerHelper.Debug(e);
               return null;
            }
             
        }
    }
}