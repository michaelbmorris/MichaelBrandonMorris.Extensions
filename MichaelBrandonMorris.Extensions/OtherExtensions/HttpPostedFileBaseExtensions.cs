using System;
using System.Web;

namespace MichaelBrandonMorris.Extensions.OtherExtensions
{
    /// <summary>
    /// Provides extensions for the <see cref="HttpPostedFileBase" /> class.
    /// </summary>
    public static class HttpPostedFileBaseExtensions
    {
        /// <summary>
        /// Copies the <see cref="HttpPostedFileBase" /> to a byte array.
        /// </summary>
        /// <param name="file">The file to be copied to a byte array.</param>
        /// <param name="offset">The offset to start reading the file from.</param>
        /// <returns></returns>
        public static byte[] ToBytes(
            this HttpPostedFileBase file,
            int offset = 0)
        {
            if (file == null)
            {
                throw new ArgumentNullException();
            }

            var bytes = new byte[file.ContentLength];
            file.InputStream.Read(bytes, offset, bytes.Length);
            return bytes;
        }
    }
}