using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectCryptLib
{
    class CryptKey
    {
        // declaration
        private string strKey;

        /// <summary>
        /// Get the key
        /// </summary>
        /// <returns>String Key</returns>
        public string get()
        {
            return this.strKey;
        }

        /// <summary>
        /// Set the key
        /// </summary>
        /// <param name="message">String Key</param>
        public void set(String key)
        {
            this.strKey = key;
        }
    }
}
