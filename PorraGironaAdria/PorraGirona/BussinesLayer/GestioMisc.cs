using PorraGirona.DataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorraGirona.BussinesLayer
{
    public static class GestioMisc
    {
        public static int CalculaPuntsUnaPorra(Porres porra, Partits partit)
        {
            int result = 0;
            if ((porra.Golslocal == partit.Golslocal) && (porra.Golsvisitant == partit.Golsvisitant))
            {
                result = 5;
            }
            return result;
        }
        public static Bitmap ImageFromMediumBlobToBitmap(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        static public byte[] ImageFromBitmapToMediumBlob(Bitmap image)
        {
            using (var stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
    }
}
