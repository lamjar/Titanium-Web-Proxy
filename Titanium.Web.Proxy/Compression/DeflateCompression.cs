﻿using System.IO;
using System.IO.Compression;

namespace Titanium.Web.Proxy.Compression
{
    /// <summary>
    ///     Concrete implementation of deflate compression
    /// </summary>
    internal class DeflateCompression : ICompression
    {
        public Stream GetStream(Stream stream)
        {
            return new DeflateStream(stream, CompressionMode.Compress, true);
        }
    }
}
