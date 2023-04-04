
using AD.CoreCommon;
using AD.CoreERP.AD.CoreWindow;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD.Core.DepartMentManager;
using AD.CoreCommon.DataModel.ClientData;
using AD.CoreERP.AD.CoreClientSystem.AD.CoreWindowSys;
using AD.CoreERP.Other.OtherManager.OtherManagerWindowSys;
using Sunny.UI;

namespace AD.CoreERP.AD.CoreWindowSys
{
    public  class LoginWindowSys
    {
        public static LoginWindowSys Instance;
        private LoginWindow LoginWindow = null;
       // private static  bool  States=false;
        private IFreeSql _freeSql = FreeSqlHelper.Sqlite;
        public void Awake()
        {
            Instance = this;
        }
       
         /// <summary>
         /// 一手机号
         /// </summary>
         /// <param name="acc"></param>
         /// <param name="pass"></param>
         /// <returns></returns>
         public int LoginGameByPhoneNumber(string acc, string pass  )
         {
            var sl = _freeSql.Select<RegisterTable>().Where(a => a.TelPhone == acc && a.Password == pass).ToOne();
            if (sl != null)
            {
                if (sl.HandleState == 0 )
                {
                    UIMessageBox.ShowWarning("当前可登录,请在弹出的页面中完善你的身份信息！！");
                    return 0;

                }
                else if(sl.HandleState==1)
                {
                    UIMessageBox.ShowWarning("当前你的数据存在系统中，我们正在处理，暂不可登录,请等待！！");
                    return 2;
                }
                return -1;
            }
            else
            {
               var pl = _freeSql.Select<UserData>().Where(a => a.TelPhone == acc && a.Password == pass).ToOne();
               if (pl == null)
               {
                   UIMessageBox.ShowError("当前数据不存在系统中，请注册！！");
                   return -1;
               }
               else
               {
                   return 1;
               }
            }
         }

        /// <summary>
        /// 电话号码的形式登录
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int LoginGameByAccount (string acc, string pass)
        { 
            var sl = _freeSql.Select<RegisterTable>().Where(a => a.Account == acc && a.Password == pass).ToOne();
            if (sl != null)
            {
                if (sl.HandleState == 0 && sl.Department == null)
                {
                    UIMessageBox.ShowWarning("当前可登录,请在弹出的页面中完善你的身份信息！！");
                    return 0;

                }
                else if (sl.HandleState == 1)
                {
                    UIMessageBox.ShowWarning("当前你的数据存在系统中，我们正在处理，暂不可登录,请等待！！");
                    return 2;
                }
                return -1;
            }
            else
            {
                var pl = _freeSql.Select<UserData>().Where(a => a.Account == acc && a.Password == pass).ToOne();
                if (pl == null)
                {
                    UIMessageBox.ShowError("当前数据不存在系统中，请注册！！");
                    return -1;
                }
                else
                {
                    return  1 ;
                }
            }

        }


        /// <summary>
        /// 
        /// </summary>
        public  void ToRegisterWindow()
        {
            RigisterWindowSys.Instance.ShowRegisterWindow();
        }
       


        public void ShowLoginWindow()
        {
            LoginWindow = new LoginWindow();
            LoginWindow.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        public void ShowFactoryManagerWindow()
        {
            FactoryManager.FactoryManager.FactoryManagerWindowSys.MainWindowSys.Instance
                .ShowFactoryManagerWindow(_freeSql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="state"></param>
        public void ShowOtherFactoryPersonWindow(string acc,string pass)
        {
            Other.OtherManager.OtherManagerWindowSys. MainWindowSys.Instance.ShowOtherMainWindow(acc, pass,_freeSql);
        }

       
        /// <summary>
        /// 查询当前登录的是不是工厂管理员
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="isPhone"></param>
        /// <exception cref="NotImplementedException"></exception>
        public bool  SelectCurrentLoginMessageFactoryManager(string acc, string pass, bool isPhone)
        {
            if (isPhone)
            {
                var pl = _freeSql.Select<UserData>().Where(a => a.TelPhone == acc && a.Password == pass).ToOne();
                if (pl != null)
                {
                    if (pl.IsFactoryManager)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            else
            {
                var pl = _freeSql.Select<UserData>().Where(a => a.Account == acc && a.Password == pass).ToOne();
                if (pl != null)
                {
                    if (pl.IsFactoryManager)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
                
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="acc"></param>
        /// <param name="pass"></param>
        /// <param name="isPhone"></param>
        /// <param name="departName"></param>
        /// <returns></returns>
        public string  SelectCurrentLoginMessageDepartMentData(string acc, string pass, bool isPhone )
        {
            if (isPhone)
            {
                var pl = _freeSql.Select<UserData>().Where(a => a.TelPhone == acc && a.Password == pass).ToOne();
                if (pl != null)
                {
                    return pl.DepartMent;
                }
                else
                    return null;
            }
            else
            {
                var pl = _freeSql.Select<UserData>().Where(a => a.Account == acc && a.Password == pass).ToOne();
                if (pl != null)
                {
                    return pl.DepartMent;
                }
                else
                    return null;
            }
        }

        public void ShowDepartMentWindow(string departName, string acc, string pass, bool isPhone)
        {
             DepartMentManager.Instance.ShowDepartMentWindow(departName,acc,pass,_freeSql,isPhone);
        }
    }
}
