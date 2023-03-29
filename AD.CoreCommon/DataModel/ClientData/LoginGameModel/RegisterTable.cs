using FreeSql.DataAnnotations;
using System.Drawing;

namespace AD.CoreCommon.DataModel.ClientData
{
    public class RegisterTable
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int id { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public  string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public  string Password { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public  string TelPhone { get; set; }
        /// <summary>
        /// 处理状态 0 表示为处理 1 表示处理中
        /// </summary>
        public int HandleState { get; set; }
        /// <summary>
        /// 部门信息
        /// </summary>
        public  string Department { get;set; }
        /// <summary>
        /// 现在地址
        /// </summary>
        public string NowAddress { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string familyAddress { get; set; }
        /// <summary>
        /// 身份证信息
        /// </summary>
        public int PersonIDCard { get; set; }
        /// <summary>
        /// 薪资
        /// </summary>
        public string SalaryData { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] PersonPicture { get; set; }   
        
         
    }
}