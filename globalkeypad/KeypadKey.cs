using System.Collections.Generic;

namespace globalkeypad.Keys
{
    public class KeypadKey
    {
        public char NumericKey { get; set; }
        //public char AlphabeticKey { get; set;  } 
        public List<char> AlphabeticKeys { get; private set; }


        public static List<KeypadKey> MobilePhoneKeypad
        {
            get
            {
                var _mpk = new List<KeypadKey>
                {
                    new KeypadKey() {NumericKey = '0',  AlphabeticKeys = new List<char>() {' ' } },
                    new KeypadKey() {NumericKey = '1',  AlphabeticKeys = new List<char>() },
                    new KeypadKey() {NumericKey = '2',  AlphabeticKeys = new List<char>() {'a', 'b', 'c'} },
                    new KeypadKey() {NumericKey = '3',  AlphabeticKeys = new List<char>() {'d', 'e', 'f'} },
                    new KeypadKey() {NumericKey = '4',  AlphabeticKeys = new List<char>() {'g', 'h', 'i'} },
                    new KeypadKey() {NumericKey = '5',  AlphabeticKeys = new List<char>() {'j', 'k', 'l'} },
                    new KeypadKey() {NumericKey = '6',  AlphabeticKeys = new List<char>() {'m', 'n', 'o'} },
                    new KeypadKey() {NumericKey = '7',  AlphabeticKeys = new List<char>() {'p', 'q', 'r', 's'} },
                    new KeypadKey() {NumericKey = '8',  AlphabeticKeys = new List<char>() {'t', 'u', 'v'} },
                    new KeypadKey() {NumericKey = '9',  AlphabeticKeys = new List<char>() {'w', 'x', 'y', 'z'} },
                    new KeypadKey() {NumericKey = '*',  AlphabeticKeys = new List<char>() },
                    new KeypadKey() {NumericKey = '#',  AlphabeticKeys = new List<char>() },
                };

                return _mpk;
            }
        }
    }
}
