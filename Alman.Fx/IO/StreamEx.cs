using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Fx.IO
{
    public static class StreamEx
    {
        public static long BoundedCopyTo(this Stream source, Stream destination, long length)
        {
            var buffer = new byte[1024];
            long totalBytesRead = 0;
            int currentBytesRead;
            while (true)
            {
                var bytesToRead = 1024;
                if (totalBytesRead + bytesToRead > length)
                    bytesToRead = (int)(length - totalBytesRead);

                currentBytesRead = source.Read(buffer, 0, bytesToRead);
                if (currentBytesRead <= 0)
                    break;

                totalBytesRead += currentBytesRead;
                destination.Write(buffer, 0, currentBytesRead);

                if (totalBytesRead == length)
                    break;
            }

            return totalBytesRead;
        }

        public static void Write(this Stream source, byte[] buffer)
        {
            source.Write(buffer, 0, buffer.Length);
        }

        public static void Write(this Stream source, string s, Encoding encoding)
        {
            source.Write(encoding.GetBytes(s));
        }
    }
}
