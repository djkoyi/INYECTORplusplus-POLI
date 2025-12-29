using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INYECTOR.clases
{
    public class Funciones
    {
        public static string SHA1(string strToHash)
        {
            using (System.Security.Cryptography.SHA1CryptoServiceProvider sha1Obj = new System.Security.Cryptography.SHA1CryptoServiceProvider())
            {
                byte[] bytesToHash = Encoding.ASCII.GetBytes(strToHash);
                bytesToHash = sha1Obj.ComputeHash(bytesToHash);
                string strResult = "";
                foreach (byte b in bytesToHash)
                {
                    strResult += b.ToString("x2");
                }
                return strResult;
            }
        }
    }

}
