using AD.CoreCommon.DataModel.ClientData;
using AD.CoreERP.Other_;
using AD.CoreERP.Other_.OtherManager.OtherManagerWindow;
using GameLog.LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD.CoreERP.Other.OtherManager.OtherManagerWindowSys
{
    public class MainWindowSys
    {
        public static MainWindowSys Instance;
        private MainWindow _personDataWindowWindow = null;
        IFreeSql freeSql = null;
         
        public  void Awake()
        {
            Instance = this;
        }
        /// <summary>
        /// 
        /// </summary>
        public void ShowOtherMainWindow(string acc,string pass, IFreeSql _freeSql)
        {
            freeSql = _freeSql;
            _personDataWindowWindow = new MainWindow();
            _personDataWindowWindow. account = acc;
            _personDataWindowWindow.password=pass;
            _personDataWindowWindow.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public  RegisterTable LoadingInintdata(string account, string password)
        {
            RegisterTable list = new RegisterTable();
            if (RegexHelper.CheckMobilePhone(account))
            {
                list = freeSql.Select<RegisterTable>().Where(A => A.TelPhone == account && A.Password == password).ToOne();
                if (list != null  )
                {
                    return list;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                list = freeSql.Select<RegisterTable>().Where(A => A.Account == account && A.Password == password).ToOne();
                if (list != null  )
                {
                    return list;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="flowLayoutPanel1"></param>
        /// <returns></returns>
        public List<DepartMentModel> LoadingDepartMentData( )
        {
             
            List<DepartMentModel> departMentModels = new List<DepartMentModel> ();
            try
            {
                var sl = freeSql.Select<DepartMentModel>().Distinct().ToList(a => new {a.departMentName,a.departIntroduce,a.departPicture});
                if(sl != null)
                {
                    foreach(var item in sl)
                    {
                        DepartMentModel model = new DepartMentModel()
                        {
                            departIntroduce = item.departIntroduce,
                            departPicture = item.departPicture,
                            departMentName = item.departMentName,
                        };
                        departMentModels.Add(model);
                    }
                    return departMentModels;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                LoggerHelper.Debug(ex);
                return null;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="departMentData"></param>
        /// <param name="departMentModels"></param>
        /// <param name="flowLayoutPanel1"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void ShowDepartMentDataView(ref List<DepartMentData> departMentData, List<DepartMentModel> departMentModels, FlowLayoutPanel flowLayoutPanel1)
        {
            flowLayoutPanel1.Controls .Clear();
            foreach (var item in departMentModels)
            {
                DepartMentData data = new DepartMentData();
                data.P_SetDepartMentName = item.departMentName;
                data.P_SetDepartMentDescription = item.departIntroduce;
                if (item.departPicture==null)
                    data.P_SetDepartMentPicture = null;
                else
                    data.P_SetDepartMentPicture = ImageHelper.BytesToBitmap(item.departPicture);
                departMentData.Add(data);
                flowLayoutPanel1.Controls.Add(data);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public string OpenChooseLocalImageFile()
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Multiselect = true;  //该值确定是否可以选择多个文件
            openFileDialog2.Title = "请选择图片文件";
        
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog2.FileName != "")
                {
                    string psth = openFileDialog2.FileName;
                   if(ImageHelper. JudgeIsImageFile(psth))
                         return psth;
                   else return null;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
           
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        public bool InsertDataToRegister(RegisterTable userData)
        {
            if (ClearDataBase(userData.Account, userData.TelPhone, userData.Password))
            {
                int result = freeSql.InsertOrUpdate<RegisterTable>().SetSource(userData).ExecuteAffrows();
                if (result == 1) return true;
                else { return false; }
            }
            else { return false; }

        }
        /// <summary>
        /// 删除之前的注册信息
        /// </summary>
        /// <param name="account"></param>
        /// <param name="telPhone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private  bool ClearDataBase(string account, string telPhone, string password)
        {
            var res = freeSql.Select<RegisterTable>().Where(a => a.Account == account && a.TelPhone == telPhone && a.Password == password).ToOne();
            if (res != null)
            {
                var sl = freeSql.Delete<RegisterTable>().Where(a => a.Account == account && a.TelPhone == telPhone && a.Password == password).ExecuteAffrows();
                if (sl == 1) return true;
                else return false;
            }
            else return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registerTable"></param>
        /// <param name="account"></param>
        /// <param name="pass"></param>
        /// <param name="tel"></param>
        /// <returns></returns>
        public bool ChangePersonData(RegisterTable registerTable, string account, string pass, string tel)
        {
            if (ClearDataBase(registerTable.Account, registerTable.TelPhone, registerTable.Password))
            {
                RegisterTable registerTables = new RegisterTable()
                {
                    Account = account,
                    Password = pass,
                    TelPhone = tel,
                    HandleState = registerTable.HandleState,
                    Department = registerTable.Department,
                    Email = registerTable.Email,
                    familyAddress = registerTable.familyAddress,
                    NowAddress = registerTable.NowAddress,
                    SalaryData = registerTable.SalaryData,
                    PersonIDCard = registerTable.PersonIDCard,
                    PersonPicture = registerTable.PersonPicture,
                };
                int result = freeSql.InsertOrUpdate<RegisterTable>().SetSource(registerTables).ExecuteAffrows();
                if (result == 1) return true;
                else { return false; }
            }
            else
            {
                return false;
            }
        }
    }
}
