using HerrNyani.KanaBenkyou.Models.Characters;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting
{
    public class KanaPhoneticShiftItemViewModel
    {
        private readonly KanaPhoneticShift _phoneticShift;

        public KanaPhoneticShiftItemViewModel(KanaPhoneticShift phoneticShift)
        {
            _phoneticShift = phoneticShift;
        }

        public char Diacritic => _phoneticShift.Diacritic;
        public string DiacriticName
        {
            get
            {
                switch(Diacritic)
                {
                    case 'ﾞ':
                        return "Dakuten";
                    case 'ﾟ':
                        return "Handakuten";
                    default:
                        return "Unknown diacritic";
                }
            }
        }
        public char Character => _phoneticShift.Character;
        public string Romaji => _phoneticShift.Romaji;
    }
}
