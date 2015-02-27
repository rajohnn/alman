﻿using Alman.Fx.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Fx.Security
{
    /// <summary>
    /// Provides commonly used utilities for computing cryptographic hashes.
    /// </summary>
    public static class Hash
    {
        public static byte[] HashStream<T>(Func<T> algorithm, Stream input) where T : HashAlgorithm
        {
            using (var hash = algorithm())
            {
                using (var cryptoStream = new CryptoStream(Stream.Null, hash, CryptoStreamMode.Write))
                {
                    StreamEx.BoundedCopyTo(input, cryptoStream, long.MaxValue);
                    cryptoStream.FlushFinalBlock();
                    return hash.Hash;
                }
            }
        }

        /// <summary>
        /// Hashes the contents of a string using the crypto algorithm returned by <paramref name="algorithm"/>.
        /// Returns a hex-encoded string containing the hash value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="algorithm">A function returning a HashAlgorithm.</param>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string HashStreamString<T>(Func<T> algorithm, Stream input) where T : HashAlgorithm
        {
            var hash = HashStream(algorithm, input);
            return string.Join("", hash.Select(b => b.ToString("X2")).ToArray());
        }

        /// <summary>
        /// Returns the SHA1 hash of the given string, encoded using the given encoding.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="encoding">The encoding used to produce a byte stream for hashing.</param>
        /// <returns>A string containing a textual representation of the SHA1 hash.</returns>
        public static string Sha1(string input, Encoding encoding)
        {
            var ms = new MemoryStream(encoding.GetBytes(input));
            return Sha1(ms);
        }

        /// <summary>
        /// Returns the SHA256 hash of the given string, encoded using the given encoding.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="encoding">The encoding used to produce a byte stream for hashing.</param>
        /// <returns>A string containing a textual representation of the SHA256 hash.</returns>
        public static string Sha256(string input, Encoding encoding)
        {
            using (var ms = new MemoryStream(encoding.GetBytes(input)))
                return Sha256(ms);
        }

        /// <summary>
        /// Returns the SHA1 hash of the contents of a stream.
        /// </summary>
        /// <param name="input">The stream to hash.</param>
        /// <returns>A string containing a textual representation of the SHA1 hash.</returns>
        public static string Sha1(Stream input)
        {
            return HashStreamString(SHA1.Create, input);
        }

        /// <summary>
        /// Returns the SHA256 hash of the contents of a stream.
        /// </summary>
        /// <param name="input">The stream to hash.</param>
        /// <returns>A string containing a textual representation of the SHA256 hash.</returns>
        public static string Sha256(Stream input)
        {
            return HashStreamString(SHA256.Create, input);
        }

        /// <summary>
        /// Returns the SHA512 hash of the contents of a stream.
        /// </summary>
        /// <param name="input">The stream to hash.</param>
        /// <returns>A byte array of the SHA512 hash.</returns>
        public static byte[] Sha512Bytes(Stream input)
        {
            return HashStream(SHA512.Create, input);
        }

        /// <summary>
        /// Returns the SHA512 hash of the contents of a stream.
        /// </summary>
        /// <param name="input">The stream to hash.</param>
        /// <param name="encoding">The encoding used to produce a byte stream for hashing.</param>
        /// <returns>A byte array of the SHA512 hash.</returns>
        public static byte[] Sha512Bytes(string input, Encoding encoding)
        {
            using (var ms = new MemoryStream(encoding.GetBytes(input)))
                return Sha512Bytes(ms);
        }

        /// <summary>
        /// Returns the SHA1 hash of the file given by path.
        /// </summary>
        /// <param name="path">The path of the file to hash.</param>
        /// <returns>A string containing a textual representation of the SHA1 hash.</returns>
        public static string Sha1File(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Sha1(fs);
            }
        }

        /// <summary>
        /// Returns the HMAC-SHA1 message digest if the stream given by input,
        /// using the given secret key.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="input">The input stream for which the digest will be computed.</param>
        /// <returns>A hex string containing the HMAC-SHA1 digest value.</returns>
        public static string HmacSha1(byte[] secretKey, Stream input)
        {
            return HashStreamString(() => new HMACSHA1 { Key = secretKey }, input);
        }

        public static string HmacSha1(string secretKey, string message, Encoding encoding)
        {
            return HmacSha1(encoding.GetBytes(secretKey), new MemoryStream(encoding.GetBytes(message)));
        }

        public static string HmacSha1(string secretKey, string message)
        {
            return HmacSha1(secretKey, message, Encoding.UTF8);
        }

        /// <summary>
        /// Returns the HMAC-SHA256 message digest if the stream given by input,
        /// using the given secret key.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="input">The input stream for which the digest will be computed.</param>
        /// <returns>A hex string containing the HMAC-SHA256 digest value.</returns>
        public static string HmacSha256(byte[] secretKey, Stream input)
        {
            return HashStreamString(() => new HMACSHA256 { Key = secretKey }, input);
        }

        public static string HmacSha256(string secretKey, string message, Encoding encoding)
        {
            return HmacSha256(encoding.GetBytes(secretKey), new MemoryStream(encoding.GetBytes(message)));
        }

        public static string HmacSha256(string secretKey, string message)
        {
            return HmacSha256(secretKey, message, Encoding.UTF8);
        }

        public static byte[] HmacSha512(byte[] secretKey, string message, Encoding encoding)
        {
            return HashStream(() => new HMACSHA512 { Key = secretKey }, new MemoryStream(encoding.GetBytes(message)));
        }
    }
}
