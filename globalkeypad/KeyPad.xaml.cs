using globalkeypad.Keys;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace globalkeypad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<KeypadKey> _mpKeypad;
        private const decimal _keypressTime = 0.100m;
        private const decimal _keypressPause = 0.500m;

        private decimal _userkpTime;
        public MainWindow()
        {
            InitializeComponent();
            _mpKeypad = KeypadKey.MobilePhoneKeypad;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string _input = txtInputString.Text.ToLowerInvariant();
            StringBuilder _keySequence = new StringBuilder();
            //sb.Append(c);
            _userkpTime = 0.0m;
            int _dpp = -1;
            _keySequence.Clear();

            //enumerate each character in the input string
            foreach (char c in _input)
            {
                foreach (KeypadKey kk in _mpKeypad)
                {
                    //search for the input character in the keypad character lists
                    if(kk.AlphabeticKeys.Exists(_c => _c.Equals(c)))
                    {
                        int _dp = _mpKeypad.IndexOf(kk);
                        if (_dpp == _dp)
                            _userkpTime = _userkpTime + _keypressPause;

                        _userkpTime = _userkpTime + _keypressTime;
                        for(int i = 0; i<=kk.AlphabeticKeys.IndexOf(c); i++)
                            _keySequence.Append(kk.NumericKey);
                       
                        _dpp = _dp;
                        break;
                    }
                }
            }
            lbOut.Content = _userkpTime.ToString("0.##") + " second(s)";
            lbSequenceOut.Content = _keySequence.ToString();
        }
    }
}
