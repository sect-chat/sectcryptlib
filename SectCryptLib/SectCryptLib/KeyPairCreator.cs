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

            ulong n = (ulong) p * (ulong) q;

            Console.WriteLine("0: " + this.phi(0));
            Console.WriteLine("1: " + this.phi(1));
            Console.WriteLine("2: " + this.phi(2));
            Console.WriteLine("3: " + this.phi(3));
            Console.WriteLine("4: " + this.phi(4));
            Console.WriteLine("5: " + this.phi(5));
            Console.WriteLine("6: " + this.phi(6));
            Console.WriteLine("7: " + this.phi(7));
            Console.WriteLine("8: " + this.phi(8));
            Console.WriteLine("9: " + this.phi(9));
            Console.WriteLine("13: " + this.phi(13));
            

            Console.WriteLine(p+" x "+q+" = "+n);
            Console.ReadLine();
        }

        /// <summary>
        /// get a prime number between from and to
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private int getPrime(int from, int to)
        {
            int maybePrime;

            do
            {
                maybePrime = this.rnd.Next(from, to);
            } while (!this.isPrime(maybePrime));

            return maybePrime;            
        }

        /// <summary>
        /// check if number is a prime number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private bool isPrime(int number)
        {
            if (number < 2) return false;

            if (number % 2 == 0) return false;

            long upperBorder = (long)System.Math.Round(System.Math.Sqrt(number), 0);
            for (long i = 3; i <= upperBorder; i = i + 2)
                if (number % i == 0) return false;
            return true;
        }

        private ulong phi(ulong number)
        {
            ulong returnPhi = 0;

            for (ulong i = 0; i <= number; i++)
            {
                bool isCoprime = true;

                for (ulong j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if (number % j == 0)
                        {
                            isCoprime = false;
                            break;
                        }
                    }
                }

                if (isCoprime) returnPhi++;
            }


            return returnPhi;
        }
    }
}
