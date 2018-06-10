namespace HerrNyani.KanaBenkyou.Models.Characters
{
    public class KanaPhoneticShift
    {
        public KanaPhoneticShift(char diacritic, char character, string romaji, char vowel, char consonant)
        {
            Diacritic = diacritic;
            Character = character;
            Romaji = romaji;
            Vowel = vowel;
            Consonant = consonant;
        }

        public char Diacritic { get; }
        public char Character { get; }
        public string Romaji { get; }
        public char Consonant { get; }
        public char Vowel { get; }
    }
}
