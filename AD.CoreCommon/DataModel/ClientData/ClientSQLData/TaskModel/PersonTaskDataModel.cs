using FreeSql.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.CoreCommon.DataModel.ClientData.TaskModel
{
     /// <summary>
     /// 个人任务型类型
     /// </summary>
    public  class PersonTaskDataModel
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        
        public int ID { get; set; }
        /// <summary>
        /// 任务信息
        /// </summary>
        public string TaskData { get; set; }
        /// <summary>
        /// 任务分配对象
        /// </summary>
        public string TaskBelongName { get; set; }
        /// <summary>
        /// 任务状态 0 未完成 1 进行中 2已完成
        /// </summary>
        public int TaskState { get; set; }
        /// <summary>
        /// 任务开始时间
        /// </summary>
        public int TaskStartTime { get; set; }
        /// <summary>
        /// 任务结束时间
        /// </summary>
        public int TaskEndTime { get; set; }
        /// <summary>
        /// 任务类型 0 日常任务 1 其它任务
        /// </summary>
        public int TaskKinds { get;set; }
        /// <summary>
        /// 任务的紧急程度 0 表示一般，1 表示紧急任务
        /// 
        /// </summary>
        public int TaskStatus { get; set; }

    }
}
