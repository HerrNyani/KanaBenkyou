using HerrNyani.KanaBenkyou.Models.Characters;
using System;
using System.Diagnostics;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting
{
    [DebuggerDisplay("[nameof(KanaChartItemViewModel)] {Character.ToString()} ({Romaji})")]
    public class KanaChartItemViewModel
    {
        private readonly Kana _kana;

        public KanaChartItemViewModel(Kana kana)
        {
            _kana = kana;
        }

        public char Character => _kana.Character;
        public string Romaji => _kana.Romaji;

        public int GridColumnIndex
        {
            get
            {
                switch (Char.ToLower(_kana.Consonant))
                {
                    case 'w':
                        return 0;
                    case 'r':
                        return 1;
                    case 'y':
                        return 2;
                    case 'm':
                        return 3;
                    case 'h':
                        return 4;
                    case 'n':
                        return 5;
                    case 't':
                        return 6;
                    case 's':
                        return 7;
                    case 'k':
                        return 8;
                    case '\0':
                        return 9;
                    default:
                        throw new ArgumentException("Invalid kana consonant.");
                }
            }
        }

        public int GridRowIndex
        {
            get
            {
                switch (Char.ToLower(_kana.Vowel))
                {
                    case 'a':
                        return 0;
                    case 'i':
                        return 1;
                    case 'u':
                        return 2;
                    case 'e':
                        return 3;
                    case 'o':
                        return 4;
                    case '\0':
                        return 5;
                    default:
                        throw new ArgumentException("Invalid kana vowel.");
                }
            }
        }

        internal Kana Kana => _kana;

        public override int GetHashCode()
        {
            return _kana.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj)
                || obj is KanaChartItemViewModel itemViewModel
                    && _kana.Equals(itemViewModel._kana);
        }
    }
}
