using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AD.CoreCommon.DataModel.ClientData;
using AD.CoreERP.AD.CoreClientSystem.AD.CoreWindow;
using GameLog.LogHelper;

namespace AD.CoreERP.AD.CoreClientSystem.AD.CoreWindowSys
{
    public class RigisterWindowSys
    {
        public static RigisterWindowSys Instance;
        public  void Awake()
        {
            Instance = this;
        }

        private RigisterWindow RegisterWindow = null;

        private IFreeSql _freeSql = FreeSqlHelper.ServerSql;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="telPhone"></param>
        /// <returns></returns>
        public bool SaveDataToDataBase(string acc, string pass, string telPhone )
        {
            try 
            {
                var pos = _freeSql.Select<RegisterTable>().Where(a => a.Account == acc && a.Password == pass ).ToOne();
                if (pos != null)
                {
                    return false;
                }
                else
                {
                    RegisterTable RegisterTable = new RegisterTable()
                    {
                        Account = acc,
                        Password = pass,
                        TelPhone = telPhone,
                        HandleState=0,
                      
                    };
                    var sl = _freeSql.Insert<RegisterTable>(RegisterTable).ExecuteAffrows();
                    if (sl > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerHelper.Debug(ex);
                return false;
            }
        }

        public void ShowRegisterWindow()
        {
             RegisterWindow  = new RigisterWindow();
             RegisterWindow.Show();
        }
    }
}
