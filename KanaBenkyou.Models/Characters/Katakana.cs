using System.Collections.Generic;

namespace HerrNyani.KanaBenkyou.Models.Characters
{
    public class Katakana
    {
        private static readonly List<Kana> _katakana = new List<Kana>
        {
            new Kana('ワ', "wa", 'a', 'w'),
            new Kana('ヲ', "wo", 'o', 'w'),

            new Kana('ン', "n", '\0', 'n'),

            new Kana('ラ', "ra", 'a', 'r'),
            new Kana('リ', "ri", 'i', 'r'),
            new Kana('ル', "ru", 'u', 'r'),
            new Kana('レ', "re", 'e', 'r'),
            new Kana('ロ', "ro", 'o', 'r'),

            new Kana('ヤ', "ya", 'a', 'y'),
            new Kana('ユ', "yu", 'u', 'y'),
            new Kana('ヨ', "yo", 'o', 'y'),

            new Kana('マ', "ma", 'a', 'm'),
            new Kana('ミ', "mi", 'i', 'm'),
            new Kana('ム', "mu", 'u', 'm'),
            new Kana('メ', "me", 'e', 'm'),
            new Kana('モ', "mo", 'o', 'm'),

            new Kana('ハ', "ha", 'a', 'h'),
            new Kana('ヒ', "hi", 'i', 'h'),
            new Kana('フ', "fu", 'u', 'h'),
            new Kana('ヘ', "he", 'e', 'h'),
            new Kana('ホ', "ho", 'o', 'h'),

            new Kana('ナ', "na", 'a', 'n'),
            new Kana('ニ', "ni", 'i', 'n'),
            new Kana('ヌ', "nu", 'u', 'n'),
            new Kana('ネ', "ne", 'e', 'n'),
            new Kana('ノ', "no", 'o', 'n'),

            new Kana('タ', "ta", 'a', 't'),
            new Kana('チ', "chi", 'i', 't'),
            new Kana('ツ', "tsu", 'u', 't'),
            new Kana('テ', "te", 'e', 't'),
            new Kana('ト', "to", 'o', 't'),

            new Kana('サ', "sa", 'a', 's'),
            new Kana('シ', "shi", 'i', 's'),
            new Kana('ス', "su", 'u', 's'),
            new Kana('セ', "se", 'e', 's'),
            new Kana('ソ', "so", 'o', 's'),

            new Kana('カ', "ka", 'a', 'k'),
            new Kana('キ', "ki", 'i', 'k'),
            new Kana('ク', "ku", 'u', 'k'),
            new Kana('ケ', "ke", 'e', 'k'),
            new Kana('コ', "ko", 'o', 'k'),

            new Kana('ア', "a", 'a', '\0'),
            new Kana('イ', "i", 'i', '\0'),
            new Kana('ウ', "u", 'u', '\0'),
            new Kana('エ', "e", 'e', '\0'),
            new Kana('オ', "o", 'o', '\0'),
        };

        public static IReadOnlyCollection<Kana> Collection => _katakana;
    }
}
