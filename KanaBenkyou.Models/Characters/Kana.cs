using System.Diagnostics;

namespace HerrNyani.KanaBenkyou.Models.Characters
{
    [DebuggerDisplay("{Character.ToString()} ({Romaji})")]
    public class Kana
    {
        public Kana(char character, string romaji, char vowel, char consonant)
        {
            Character = character;
            Romaji = romaji;
            Vowel = vowel;
            Consonant = consonant;
        }

        public char Character { get; }
        public string Romaji { get; }
        public char Vowel { get; }
        public char Consonant { get; }
    }
}
