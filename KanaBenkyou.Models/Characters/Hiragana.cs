using System.Collections.Generic;

namespace HerrNyani.KanaBenkyou.Models.Characters
{
    public static class Hiragana
    {
        private static readonly List<Kana> _hiragana = new List<Kana>
        {
            new Kana('わ', "wa", 'a', 'w'),
            new Kana('を', "wo", 'o', 'w'),

            new Kana('ん', "n", '\0', 'n'),

            new Kana('ら', "ra", 'a', 'r'),
            new Kana('り', "ri", 'i', 'r'),
            new Kana('る', "ru", 'u', 'r'),
            new Kana('れ', "re", 'e', 'r'),
            new Kana('ろ', "ro", 'o', 'r'),

            new Kana('や', "ya", 'a', 'y'),
            new Kana('ゆ', "yu", 'u', 'y'),
            new Kana('よ', "yo", 'o', 'y'),

            new Kana('ま', "ma", 'a', 'm'),
            new Kana('み', "mi", 'i', 'm'),
            new Kana('む', "mu", 'u', 'm'),
            new Kana('め', "me", 'e', 'm'),
            new Kana('も', "mo", 'o', 'm'),

            new Kana('は', "ha", 'a', 'h'),
            new Kana('ひ', "hi", 'i', 'h'),
            new Kana('ふ', "fu", 'u', 'h'),
            new Kana('へ', "he", 'e', 'h'),
            new Kana('ほ', "ho", 'o', 'h'),

            new Kana('な', "na", 'a', 'n'),
            new Kana('に', "ni", 'i', 'n'),
            new Kana('ぬ', "nu", 'u', 'n'),
            new Kana('ね', "ne", 'e', 'n'),
            new Kana('の', "no", 'o', 'n'),

            new Kana('た', "ta", 'a', 't'),
            new Kana('ち', "chi", 'i', 't'),
            new Kana('つ', "tsu", 'u', 't'),
            new Kana('て', "te", 'e', 't'),
            new Kana('と', "to", 'o', 't'),

            new Kana('さ', "sa", 'a', 's'),
            new Kana('し', "shi", 'i', 's'),
            new Kana('す', "su", 'u', 's'),
            new Kana('せ', "se", 'e', 's'),
            new Kana('そ', "so", 'o', 's'),

            new Kana('か', "ka", 'a', 'k'),
            new Kana('き', "ki", 'i', 'k'),
            new Kana('く', "ku", 'u', 'k'),
            new Kana('け', "ke", 'e', 'k'),
            new Kana('こ', "ko", 'o', 'k'),

            new Kana('あ', "a", 'a', '\0'),
            new Kana('い', "i", 'i', '\0'),
            new Kana('う', "u", 'u', '\0'),
            new Kana('え', "e", 'e', '\0'),
            new Kana('お', "o", 'o', '\0'),
        };

        public static IReadOnlyCollection<Kana> Collection => _hiragana;
    }
}
