using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD.CoreERP.Other_
{
    public partial class DepartMentData : UserControl
    {
        public DepartMentData()
        {
            InitializeComponent();
        }
        [Description("部门图片"), Category("自定义属性")]
        public Image P_SetDepartMentPicture
        {
            get { return pictureBox1.Image;  }
            set
            {
                pictureBox1.Image= value;
            }
        }
        [Description("部门名字"), Category("自定义属性")]
        public string P_SetDepartMentName
        {
            get { return departmentName.Text;    }
            set { departmentName.Text=value;}
        }
        [Description("部门简介"), Category("自定义属性")]
        public string P_SetDepartMentDescription
        {
            get
            {
                return departMentIntrduce.Text;
            }
            set
            {
                departMentIntrduce.Text = value;
            }
        }
        
         
    }
}
