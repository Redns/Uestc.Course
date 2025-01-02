using System.Security.Cryptography;
using System.Text;

namespace Uestc.Course.Core.Helpers
{
    public static class EncryptAndDecryptHelper
    {
        /// <summary>
        /// Create MD5 hash for the content.
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string CreateMD5(this string content)
        {
            return BitConverter
                .ToString(MD5.HashData(Encoding.UTF8.GetBytes(content)))
                .Replace("-", string.Empty);
        }
    }
}
