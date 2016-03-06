using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TP_Lab_1
{
    
    class Key
    {
        private RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
        private String publicKey = null;
        private String privateKey = null;
        private static Key instance = null;

        private Key()
        {
            publicKey = rsaKey.ToXmlString(false);
            privateKey = rsaKey.ToXmlString(true);
        }

        public static Key GetInstance()
        {
            return instance ?? (instance = new Key());
        }

        public string PublicKey
        {
            get { return publicKey; }
        }

        public string PrivateKey
        {
            get { return privateKey; }
        }
    }
}
