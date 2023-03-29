using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.CoreCommon.DataModel.ClientData 
{
    /// <summary>
    /// 用户信息基类
    /// </summary>
    public class UserData
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int id { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string TelPhone { get; set; }
        /// <summary>
        /// 部门信息
        /// </summary>
        public string DepartMent { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string NowAddress { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string FamilyAddress { get; set; }
        /// <summary>
        /// 薪资
        /// </summary>
        public string SalaryData { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public int IDPassword { get; set; }

        public string StartWorkTime { get; set; }   
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] personDataPicture { get; set; }  


    }
}
