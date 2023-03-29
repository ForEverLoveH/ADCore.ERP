using AD.CoreERP.AD.CoreClientSystem;
using AD.CoreERP.AD.CoreWindow;
using AD.CoreERP.AD.CoreWindowSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD.CoreERP.AD.CoreClientSystem.AD.CoreWindowSys;
using AD.CoreERP.Other.OtherManager.OtherManagerWindowSys;

namespace AD.CoreERP
{
    public  class GameRoot
    {
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern void SetForegroundWindow(IntPtr mainWindowHandle);
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        
        private static LoginWindowSys LoginWindowSys = new LoginWindowSys();
        private static RigisterWindowSys _rigisterWindowSys = new RigisterWindowSys();
        private static WriteLogHelper WriteLoggerHelper = new WriteLogHelper();
        #region 工厂管理
         FactoryManager.FactoryManager.FactoryManagerWindowSys.MainWindowSys mainWindowSys = new FactoryManager.FactoryManager.FactoryManagerWindowSys.MainWindowSys();
        #endregion

        #region 其它人员
        private Other.OtherManager.OtherManagerWindowSys.MainWindowSys  MainWindowSys = new MainWindowSys();
        
       
        
        #endregion



        public void GameStart()
        {
            Awake();
            
        }

        
        

        private void Awake()
        {
            WriteLoggerHelper.Awake();
            LoginWindowSys.Awake();
            _rigisterWindowSys.Awake();
            #region 工厂管理
            mainWindowSys.Awake();
            #endregion
            # region  其它人员
            MainWindowSys.Awake();
            
            
            #endregion




        }


    }
}
