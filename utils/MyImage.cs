using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_commercial.utils
{
   public  class MyImage
    {       

       /*
                * insert ou Update Image BD  
                *   FileName(chemin)  => byte[]  binaire
                *   
       */
       public static byte[] convertImageToByte(string fileName)
        {
            //Creation d'une Image à partir du Chemin
            Image image = Image.FromFile(fileName);
            MemoryStream stream = new MemoryStream();
            //Convertir mon image en un flux dans le stream
            image.Save(stream, ImageFormat.Png);
            //Collecte le flux en Byte
            return stream.ToArray();
        }

         /* 
                * Recuperation(select) d'une  Image BD 
                *  byte[] binaire => Image
        */

        public static Image  convertByteToImage(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            return Image.FromStream(stream);
        }

    }
}
