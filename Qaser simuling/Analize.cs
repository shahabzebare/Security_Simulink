using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qaser_simuling
{
    class Analize
    {
        //the frequency of the words in english lnguage
        private Dictionary<char, double> frequencyOfLetters;
        public Dictionary<char, double> FrequencyOfLetters
        {
            get { return frequencyOfLetters; }
        }

        //count of any char in message
        private Dictionary<char, double> countOfChar;
        public Dictionary<char, double> CountOfChar
        {
            get { return countOfChar; }
        }

        //frequence of liters in message
        private Dictionary<char, double> frequenceOfLettersInMessages;
        public Dictionary<char, double> FrequenceOfLettersInMessages
        {
            get { return frequenceOfLettersInMessages; }
        }

        // char key
        char[] key;
        public char[] Key
        {
            get { return key; }
        }

        //the encripted message to atck
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private string[] messagesAfterSteps;



        public Analize(string message = "")
        {
            setMessage(message);
        }


        //set Message 
        public Analize setMessage(string message) {

            inti();
            this.message = message;
            this.countNumberOfAnyCharInMessage();
            this.frequenceOfLetterInMessage();
          //  prosasseByFraquenceOfLetters();
            return this;
        }

        //Initialize data
        private void inti()
        {

            frequencyOfLetters = new Dictionary<char, double>() { 
                {'a' , 8.167},{'b' , 1.492},{'c' , 2.782},{'d' , 4.253},{'e' , 12.702},{'f' , 2.872},
                {'g' , 2.015},{'h' , 6.094},{'i' , 6.966},{'j' , 0.153},{'k' , 0.772},{'l' , 4.025},
                {'m' , 2.406},{'n' , 6.749},{'o' , 7.507},{'p' , 1.929},{'q' , 0.095},{'r' , 5.987},
                {'s' , 6.327},{'t' , 9.056},{'u' , 2.758},{'v' , 0.978},{'w' , 2.360},{'x' , 0.150},
                {'y' , 1.947},{'z' , 0.074}
            };

            Dictionary<char, double> zeroLetters = new Dictionary<char, double>(){
                {'a' , 0},{'b' , 0},{'c' , 0},{'d' , 0},{'e' , 0},{'f' , 0},
                {'g' , 0},{'h' , 0},{'i' , 0},{'j' , 0},{'k' , 0},{'l' , 0},
                {'m' , 0},{'n' , 0},{'o' , 0},{'p' , 0},{'q' , 0},{'r' , 0},
                {'s' , 0},{'t' , 0},{'u' , 0},{'v' , 0},{'w' , 0},{'x' , 0},
                {'y' , 0},{'z' , 0}
            };

            countOfChar = zeroLetters;
            frequenceOfLettersInMessages = zeroLetters;

            messagesAfterSteps = new string[2];
            key = new char[26];
        }

        private void countNumberOfAnyCharInMessage()
        {
            for (int i = 0; i < message.Length; i++)
                if (message[i] >= 'a' && message[i] <= 'z')
                    countOfChar[message[i]]++;
        }


        private void frequenceOfLetterInMessage()
        {
            double all = frequenceOfLettersInMessages.Values.Sum();
            for (int i = 0; i < countOfChar.Count; i++)
            {
                var a = countOfChar.ElementAt(i);
                frequenceOfLettersInMessages[a.Key] = (a.Value / all) * 100;
            }
        }

        private void prosasseByFraquenceOfLetters()
        {
            var sortFENL = frequencyOfLetters.OrderBy(key => key.Value);
            var sortFML = frequenceOfLettersInMessages.OrderBy(key => key.Value);
            var sortEn = sortFENL.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            var sortMs = sortFML.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);
            for (int i = 0; i < key.Length; i++)
            {
                char b = sortEn.ElementAt(i).Key;
                char m = sortMs.ElementAt(i).Key;
                int index = m - 'a';
                key[index] = b;
            }
        }

    }
}
