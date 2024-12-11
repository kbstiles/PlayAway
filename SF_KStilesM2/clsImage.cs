using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to handle anything related to images
    /// </summary>
    internal class clsImage
    {
        /// <summary>
        /// Converts image path to byte array.
        /// </summary>
        /// <param name="imagePath">Holds image path to be used for conversion</param>
        /// <returns>Returns binary form of image</returns>
        /// <example>
        /// <code>
        /// clsImage.ImageToByteArray(imgPath);
        /// </code>
        /// </example>
        public static byte[] ImageToByteArray(string imagePath)
        {
            FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, (int)fs.Length);
            fs.Close();
            return buffer;
        }

        /// <summary>
        /// Converts byte array to image.
        /// </summary>
        /// <param name="bytes">Holds byte array to be used for conversion</param>
        /// <returns>Returns image form of byte array</returns>
        /// <example>
        /// <code>
        /// clsImage.ByteArrayToImage(bytes)
        /// </code>
        /// </example>
        public static Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
