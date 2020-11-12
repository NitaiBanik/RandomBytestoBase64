using System;
using System.Security.Cryptography;

namespace CheckBase64
{
    class Program
    {
        static void Main(string[] args)
        {
            var RNG = new RNGCryptoServiceProvider();
            var bytes = new byte[32];
            RNG.GetBytes(bytes);
            var Base64String = Convert.ToBase64String(bytes);
           
        }
    }
}
