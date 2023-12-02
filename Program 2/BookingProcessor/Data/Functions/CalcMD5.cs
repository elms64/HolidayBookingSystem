// GitHub Authors: @elms64
// Cryptography method for generating checksums for validation purposes using MD5 one way hashing.  

// System Libraries and Packages
using System.Security.Cryptography;
using System.Text;

namespace BookingProcessor
{
    public static class CalcMD5
    {
        public static string CalculateMd5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
