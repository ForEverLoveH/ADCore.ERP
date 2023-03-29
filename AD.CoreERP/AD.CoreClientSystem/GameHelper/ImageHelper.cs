using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using GameLog.LogHelper;
using MySql.Data.MySqlClient;

namespace AD.CoreERP
{
    public class ImageHelper
    {
        public static byte[] GetImageToByte(Image image)
        {
            MemoryStream memoryStream = new MemoryStream();
            try
            {
                image.Save(memoryStream, ImageFormat.Bmp);
                byte[] bytes = memoryStream.GetBuffer();
                return bytes;
            }
            catch (Exception e)
            {
                LoggerHelper.Debug(e);
                return null;

            }
            finally
            {
                memoryStream.Close();
            }
        }
    }
}