using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SectCryptLib;

namespace SectCryptLibTester
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyPairCreator keycreator = new KeyPairCreator();
            keycreator.generateKeys();
        }
    }
}
