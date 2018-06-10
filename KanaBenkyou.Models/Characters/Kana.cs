using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HerrNyani.KanaBenkyou.Models.Characters
{
    [DebuggerDisplay("{Character.ToString()} ({Romaji})")]
    public class Kana
    {
        public Kana(char character, string romaji, char vowel, char consonant, IEnumerable<KanaPhoneticShift> phoneticShifts)
        {
            Character = character;
            Romaji = romaji;
            Vowel = vowel;
            Consonant = consonant;
            PhoneticShifts = phoneticShifts?.ToList() ?? new List<KanaPhoneticShift>();
        }

        public Kana(char character, string romaji, char vowel, char consonant) :
            this(character, romaji, vowel, consonant, null)
        {
        }

        public char Character { get; }
        public string Romaji { get; }
        public char Vowel { get; }
        public char Consonant { get; }
        public IReadOnlyCollection<KanaPhoneticShift> PhoneticShifts { get; }

        public override int GetHashCode()
        {
            return Character.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj)
                || obj is Kana kana
                    && Character.Equals(kana.Character)
                    && Romaji.Equals(kana.Romaji);
        }
    }
}
