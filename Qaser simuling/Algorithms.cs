using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qaser_simuling
{
    class Algorithms
    {

        #region Qasser
        public static string encriptionQaser(string message, int key)
        {

            string cipherText = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                    cipherText += Convert.ToChar((Convert.ToInt32(message[i]) - 97 + key) % 26 + 97).ToString();
            }

            return cipherText;
        }

        public static string decriptionQaser(string message, int key)
        {
            return encriptionQaser(message, 26 - key);
        }
    
        #endregion 


        #region mono Alpha bit
        public static string encriptionMono(string message, string key) {
            string cipherText = "";
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                {
                    int x = Convert.ToInt32(message[i]) - 97;
                    cipherText += key[x];
                }
            }
            return cipherText;
        }

        public static string decriptionMono(string message, string key) {
            string plainText = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                {
                    int x = key.IndexOf(message[i]);
                    plainText += Convert.ToChar(x + 97);
                }
            }

            return plainText;
        }
        #endregion

        #region Vegirnary
        public static string encriptionVeg(string msg, string key) {
            string cipherText = "";

            int j = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i]!=' ')
                {
                     cipherText += Convert.ToChar((Convert.ToInt32(msg[i]) - 97 + Convert.ToInt32(key[j]) - 97) % 26 + 97);
                     j = (j + 1) % key.Length;
                }  
            }

            return cipherText;
        }

        public static string decriptionVeg(string msg, string key)
        {
            string plainText = "";

            int j = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] != ' ')
                {
                    plainText += Convert.ToChar(((Convert.ToInt32(msg[i]) - 97) - (Convert.ToInt32(key[j]) - 97)+26) % 26 + 97);
                    j = (j + 1) % key.Length;
                }
            }

            return plainText;
        }

        #endregion
    }
}
