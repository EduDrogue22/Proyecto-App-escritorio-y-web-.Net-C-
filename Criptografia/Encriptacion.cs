using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    public class Encriptacion
    {
        public string HashMD5(string clave)
        {
            MD5 md5 = MD5.Create();

            var claveArray = Encoding.UTF8.GetBytes(clave);
            var claveHash = md5.ComputeHash(claveArray);

            return Tomd5String(claveHash);
        }

        public string Tomd5String(byte[] hashArray)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hashArray.Length; i++)
            {
                sb.Append(hashArray[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
