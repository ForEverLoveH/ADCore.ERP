using FreeSql.DataAnnotations;
using System.Drawing;

namespace AD.CoreCommon.DataModel.ClientData
{
    public class RegisterTable
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int id { get; set; }
        /// <summary>
        /// �˺�
        /// </summary>
        public  string Account { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public  string Password { get; set; }
        /// <summary>
        /// �ֻ���
        /// </summary>
        public  string TelPhone { get; set; }
        /// <summary>
        /// ����״̬ 0 ��ʾΪ���� 1 ��ʾ������
        /// </summary>
        public int HandleState { get; set; }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public  string Department { get;set; }
        /// <summary>
        /// ���ڵ�ַ
        /// </summary>
        public string NowAddress { get; set; }
        /// <summary>
        /// ��ͥסַ
        /// </summary>
        public string familyAddress { get; set; }
        /// <summary>
        /// ���֤��Ϣ
        /// </summary>
        public int PersonIDCard { get; set; }
        /// <summary>
        /// н��
        /// </summary>
        public string SalaryData { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[] PersonPicture { get; set; }   
        
         
    }
}