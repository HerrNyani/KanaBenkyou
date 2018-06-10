using HerrNyani.KanaBenkyou.Models.Characters;
using System.Collections.Generic;
using System.Linq;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting
{
    public class KanaDetailViewModel
    {
        private readonly Kana _kana;

        public KanaDetailViewModel(Kana kana)
        {
            _kana = kana;
        }

        public char Character => _kana.Character;
        public string Romaji => _kana.Romaji;
        public string Vowel => _kana.Vowel == '\0' ?
            "Consonants" :
            _kana.Vowel.ToString();
        public string Consonant => _kana.Consonant == '\0' ?
            "Vowels" :
            _kana.Consonant.ToString();

        public IEnumerable<KanaPhoneticShiftItemViewModel> PhoneticShifts => _kana.PhoneticShifts
            .Select(p => new KanaPhoneticShiftItemViewModel(p))
            .ToList();
    }
}
