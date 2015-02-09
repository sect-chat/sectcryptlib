using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectCryptLib
{
    class CryptMessage
    {
        // declaration
        private string strMessage;

        

        /// <summary>
        /// Get the string
        /// </summary>
        /// <returns>String Message</returns>
        public string get()
        {
            return this.strMessage;
        }

        /// <summary>
        /// Set the string
        /// </summary>
        /// <param name="message">String Message</param>
        public void set(String message)
        {
            this.strMessage = message;
        }
    }
}
