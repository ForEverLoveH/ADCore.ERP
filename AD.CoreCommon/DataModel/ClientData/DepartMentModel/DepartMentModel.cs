using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.CoreCommon.DataModel.ClientData 
{
    public class DepartMentModel
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int id { get; set; }
        public string departMentName { get;set; }
        public string departIntroduce { get;set; }
        public byte[] departPicture { get; set; }
    }
}
