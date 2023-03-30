using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.CoreCommon.DataModel.ClientData 
{
    public class ImageHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Bitmap BytesToBitmap(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream(data))
            {
                Bitmap image = (Bitmap)System.Drawing.Image.FromStream(memoryStream);
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
            bitmap.Save(memoryStream, ImageFormat.Bmp);
            byte[] data = memoryStream.GetBuffer();
            memoryStream.Close();
            return data;
        }
        public static bool JudgeIsImageFile(string psth)
        {
            if (psth.EndsWith(".jpg") || psth.EndsWith(".png") || psth.EndsWith(".jpeg") || psth.EndsWith(".bmp") || psth.EndsWith(".gif"))
            {
                return true;
            }
            else { return false; }
        }
    }
}
