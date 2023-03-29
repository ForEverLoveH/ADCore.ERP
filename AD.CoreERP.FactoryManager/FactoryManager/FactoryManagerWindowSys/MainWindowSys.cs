
using AD.CoreERP.FactoryManager.FactoryManager.FactoryManagerWindow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.CoreERP.FactoryManager.FactoryManager.FactoryManagerWindowSys
{
    public class MainWindowSys
    {
       public static  MainWindowSys Instance;
       private MainWindow _mainWindow = null;
       private IFreeSql _freeSql { get; set; }
        public void Awake() { Instance = this; }

        public void ShowFactoryManagerWindow(IFreeSql freeSql)
        {
            _freeSql = freeSql;
            _mainWindow = new MainWindow();
            _mainWindow.Show();

        }
    }
}
