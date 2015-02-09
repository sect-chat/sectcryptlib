using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectCryptLib
{
    public class CryptMessage
    {
        // declaration
        private string strMessage;

        /// <summary>
        /// Create new CryptMessage with string already given
        /// </summary>
        /// <param name="message">String Message</param>
        public CryptMessage(String message)
        {
            this.set(message);
        }

        /// <summary>
        /// Create empty CryptMessage
        /// </summary>
        public CryptMessage() { }

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
