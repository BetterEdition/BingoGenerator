
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BingoPladeGenerator
{
    class SavingImage
    {
        public void getCaption(int number)
        {
            Rectangle bounds = Screen.GetBounds(Point.Empty);
            bounds.Width = 750;
            bounds.Height = 370;
            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                bitmap.Save("C:\\Users\\Jespe\\Desktop\\Dataset\\My_Bingo_" + number + ".jpg", ImageFormat.Jpeg);

            }
        }
    }
}
