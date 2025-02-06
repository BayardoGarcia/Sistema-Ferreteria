using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ferreteria
{
    class Encrypt
    {
        public static string GetMD5String(string entrada)
        {
            using (MD5 md5 = MD5.Create()) // Para crear el MD5
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(entrada);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // convierte el byte array a una cadena hexadecimal 
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("X2"));

                return sb.ToString();
            }
        }
    }
}
