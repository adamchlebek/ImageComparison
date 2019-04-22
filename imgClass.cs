using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_Comparison
{
    public class imgClass
    {
        public int red;
        public int green;
        public int blue;
        public Image image;


        public imgClass(Image img) {
            image = img;
            red = 0;
            green = 0;
            blue = 0;
        }

        public int[] ScanImage()
        {
            Bitmap bmp = new Bitmap(image);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect,
                    System.Drawing.Imaging.ImageLockMode.ReadOnly,
                    bmp.PixelFormat);

            IntPtr ptr = bmpData.Scan0;

            int bytes = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr,
                           rgbValues, 0, bytes);

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    //See the link above for an explanation 
                    //of this calculation
                    int position = (y * bmpData.Stride) + (x * Image.GetPixelFormatSize(bmpData.PixelFormat) / 8);
                    blue += rgbValues[position];
                    green += rgbValues[position + 1];
                    red += rgbValues[position + 2];
                }
            }
            bmp.UnlockBits(bmpData);

            return new int[3] { red, green, blue };
        }
    }
}
