using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AD.CoreCommon.DataModel.ClientData 
{
    public class StringHelper
    {
        public static bool CheckMobilePhone(string phone)
        {
            Regex regex = new Regex("^13\\d{9}$");
            return regex.IsMatch(phone);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Bitmap BytesToBitmap(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                Bitmap image =(Bitmap) System.Drawing.Image.FromStream(memoryStream);
                return image;
            }
        }
         /// <summary>
         /// 
         /// </summary>
         /// <param name="bitmap"></param>
         /// <returns></returns>
        public static byte[] ImageToBytes(Bitmap bitmap)
         {
             MemoryStream memoryStream = new MemoryStream();
             bitmap.Save(memoryStream,ImageFormat.Bmp);
             byte[] data = memoryStream.GetBuffer();
             memoryStream.Close();
             return data;
         }
    }
}
