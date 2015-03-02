using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectCryptLib
{
    public class KeyPairCreator
    {
        // declaration
        private CryptKey PrivateKey;
        private CryptKey PublicKey;
        Random rnd = new Random();

        /// <summary>
        /// generate the keys to get them later
        /// </summary>
        public void generateKeys()
        {
            // initialization
            this.PrivateKey = new CryptKey();
            this.PublicKey = new CryptKey();

            int p = this.getPrime(10000, 999999999);
            int q = this.getPrime(10000, 999999999);

            long n = p * q;



            Console.WriteLine(p+" x "+q+" = "+n);
            Console.ReadLine();
        }

        private int getPrime(int from, int to)
        {
            int maybePrime;

            do
            {
                maybePrime = this.rnd.Next(from, to);
            } while (!this.isPrime(maybePrime));

            return maybePrime;            
        }

        private bool isPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
