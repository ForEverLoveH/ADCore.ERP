using GameLog.LogHelper;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AD.CoreERP.AD.CoreClientSystem 
{
    public  class ImageCode
    {
        /// <summary>
        ///生成随机验证码字符串
        /// </summary>
        /// <param name="codeLength"></param>
        /// <returns></returns>
        public  string CreateRandomImageCode(int codeLength)
        {
            int randNum;
            char code;
            string randomCode =string.Empty;
            for(int i=0; i<codeLength; i++)
            {
                //利用GUID 生成6 位随机数
                byte[]  buffer  = Guid.NewGuid().ToByteArray();//生成字节数组
                int seed = BitConverter.ToInt32(buffer, 0);//利用BitConvert方法把字节数组转换为整数
                Random random = new Random(seed);//以生成的整数作为随机种子
                randNum = random.Next();
                if(randNum%3==1)
                {
                    code = (char)('A' + (char)(randNum % 26));//随机大写字母
                }
                else if (randNum % 3 == 2)
                {
                    code = (char)('a' + (char)(randNum % 26));//随机小写字母
                }
                else
                {
                    code = (char)('0' + (char)(randNum % 10));//随机数字
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }

       public void CreateImageCodeBackGroup(string code,PictureBox picture)
       {
            try
            {
                int RandAngle = 45;// 随机转动角度
                int mapWidth = (int)(code.Length * 21);
                Bitmap images = new Bitmap(mapWidth, 28);//验证图片大小
                Graphics graphics= Graphics.FromImage(images);
                graphics.Clear(Color.AliceBlue);
                graphics.DrawRectangle(new Pen(Color.Black, 0), 0, 0, images.Width - 1, images.Height - 1);//画一个边框
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;//模式
                Random rand = new Random();
                Pen blakcPen = new Pen(Color.LightGray, 0);
                for(int i=0;i<50;i++)
                {
                    int x = rand.Next(0, images.Width);
                    int y = rand.Next(0, images.Height);
                    graphics.DrawRectangle(blakcPen, x, y, 1, 1);
                }
                // 验证码旋转 ，防止机器识别
                char[] chars = code.ToCharArray();//拆散字符串成单个字符
                //文字居中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };
                //定义字体
                string[] font = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial", "宋体" };
                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5);
                    Font f = new System.Drawing.Font(font[findex], 13, System.Drawing.FontStyle.Bold);//字体样式(参数2为字体大小)
                    Brush b = new System.Drawing.SolidBrush(c[cindex]);
                    Point dot = new Point(16, 16);

                    float angle = rand.Next(-RandAngle, RandAngle);//转动的度数
                    graphics.TranslateTransform(dot.X, dot.Y);//移动光标到指定位置
                    graphics.RotateTransform(angle);
                    graphics.DrawString(chars[i].ToString(), f, b, 1, 1, format);

                    graphics.RotateTransform(-angle);//转回去
                    graphics.TranslateTransform(2, -dot.Y);//移动光标到指定位置
                }
                picture.BackgroundImageLayout = ImageLayout.Stretch;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Image = images;

            }
            catch (Exception e)
            {
                LoggerHelper.Debug(e);
                MessageBox.Show("图片创建异常");
            }
       }
        

    }
}
