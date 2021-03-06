﻿using System;

namespace MichaelBrandonMorris.Extensions.Web.HttpPostedFileBase
{
    /// <summary>
    ///     Class HttpPostedFileBaseExtensions.
    /// </summary>
    /// TODO Edit XML Comment Template for HttpPostedFileBaseExtensions
    public static class HttpPostedFileBaseExtensions
    {
        /// <summary>
        ///     To the bytes.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="offset">The offset.</param>
        /// <returns>System.Byte[].</returns>
        /// <exception cref="ArgumentNullException">
        ///     file - File must
        ///     not be null.
        /// </exception>
        public static byte[] ToBytes(
            this System.Web.HttpPostedFileBase file,
            int offset = 0)
        {
            if (file == null)
            {
                throw new ArgumentNullException(
                    nameof(file),
                    "File must not be null.");
            }

            var bytes = new byte[file.ContentLength];
            file.InputStream.Read(bytes, offset, bytes.Length);
            return bytes;
        }
    }
}