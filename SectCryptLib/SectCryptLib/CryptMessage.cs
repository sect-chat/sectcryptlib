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
        private string strPlainMessage;
        private string strCryptMessage;

        /// <summary>
        /// Create empty CryptMessage
        /// </summary>
        public CryptMessage() { }

        /// <summary>
        /// Get the plain string
        /// </summary>
        /// <returns>String Message</returns>
        public string getPlain()
        {
            return this.strPlainMessage;
        }

        /// <summary>
        /// Set the plain string
        /// </summary>
        /// <param name="message">String Message</param>
        public void setPlain(String strMessage)
        {
            this.strPlainMessage = strMessage;
        }

        /// <summary>
        /// Get the encrypted string
        /// </summary>
        /// <returns>String Message</returns>
        public string getCrypt()
        {
            return this.strCryptMessage;
        }

        public void setCrypt(String strMessage)
        {
            this.strCryptMessage = strMessage;
        }
    }
}
