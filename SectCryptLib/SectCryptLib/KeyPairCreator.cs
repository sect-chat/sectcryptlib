using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectCryptLib
{
    class KeyPairCreator
    {
        // declaration
        private CryptKey PrivateKey;
        private CryptKey PublicKey;

        /// <summary>
        /// generate the keys to get them later
        /// </summary>
        public void generateKeys()
        {
            // initialization
            this.PrivateKey = new CryptKey();
            this.PublicKey = new CryptKey();


        }

        public long getPrime(int from, int to)
        {
            Random rnd = new Random();
            int maybePrime;

            do
            {
                maybePrime = rnd.Next(from, to);
            } while (!this.isPrime(maybePrime));

            return maybePrime;            
        }

        public bool isPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return true;
            }
            return false;
        }
    }
}
