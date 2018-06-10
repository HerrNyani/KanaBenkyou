using System.Collections.Generic;

namespace HerrNyani.KanaBenkyou.Models.Characters
{
    public class Katakana
    {
        private static readonly List<Kana> _katakana = new List<Kana>
        {
            new Kana('ア', "a", 'a', '\0'),
            new Kana('イ', "i", 'i', '\0'),
            new Kana('ウ', "u", 'u', '\0'),
            new Kana('エ', "e", 'e', '\0'),
            new Kana('オ', "o", 'o', '\0'),

            new Kana('カ', "ka", 'a', 'k', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ガ', "ga", 'a', 'g'),
            }),
            new Kana('キ', "ki", 'i', 'k', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ギ', "gi", 'i', 'g'),
            }),
            new Kana('ク', "ku", 'u', 'k', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'グ', "gu", 'u', 'g'),
            }),
            new Kana('ケ', "ke", 'e', 'k', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ゲ', "ge", 'e', 'g'),
            }),
            new Kana('コ', "ko", 'o', 'k', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ゴ', "go", 'o', 'g'),
            }),

            new Kana('サ', "sa", 'a', 's', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ザ', "za", 'a', 'z'),
            }),
            new Kana('シ', "shi", 'i', 's', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ジ', "ji", 'i', 'z'),
            }),
            new Kana('ス', "su", 'u', 's', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ズ', "zu", 'u', 'z'),
            }),
            new Kana('セ', "se", 'e', 's', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ゼ', "ze", 'e', 'z'),
            }),
            new Kana('ソ', "so", 'o', 's', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ゾ', "zo", 'o', 'z'),
            }),

            new Kana('タ', "ta", 'a', 't', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ダ', "da", 'a', 'd'),
            }),
            new Kana('チ', "chi", 'i', 't', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ヂ', "ji", 'i', 'd'),
            }),
            new Kana('ツ', "tsu", 'u', 't', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ヅ', "zu", 'u', 'd'),
            }),
            new Kana('テ', "te", 'e', 't', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'デ', "de", 'e', 'd'),
            }),
            new Kana('ト', "to", 'o', 't', new List<KanaPhoneticShift>{
                new KanaPhoneticShift('ﾞ', 'ド', "do", 'o', 'd'),
            }),

            new Kana('ナ', "na", 'a', 'n'),
            new Kana('ニ', "ni", 'i', 'n'),
            new Kana('ヌ', "nu", 'u', 'n'),
            new Kana('ネ', "ne", 'e', 'n'),
            new Kana('ノ', "no", 'o', 'n'),

            new Kana('ハ', "ha", 'a', 'h', new List<KanaPhoneticShift> {
                new KanaPhoneticShift('ﾞ', 'バ', "ba", 'a', 'b'),
                new KanaPhoneticShift('ﾟ', 'パ', "pa", 'a', 'p')
            }),
            new Kana('ヒ', "hi", 'i', 'h', new List<KanaPhoneticShift> {
                new KanaPhoneticShift('ﾞ', 'ビ', "bi", 'i', 'b'),
                new KanaPhoneticShift('ﾟ', 'ピ', "pi", 'i', 'p')
            }),
            new Kana('フ', "fu", 'u', 'h', new List<KanaPhoneticShift> {
                new KanaPhoneticShift('ﾞ', 'ブ', "bu", 'u', 'b'),
                new KanaPhoneticShift('ﾟ', 'プ', "pu", 'u', 'p')
            }),
            new Kana('ヘ', "he", 'e', 'h', new List<KanaPhoneticShift> {
                new KanaPhoneticShift('ﾞ', 'ベ', "be", 'e', 'b'),
                new KanaPhoneticShift('ﾟ', 'ペ', "pe", 'e', 'p')
            }),
            new Kana('ホ', "ho", 'o', 'h', new List<KanaPhoneticShift> {
                new KanaPhoneticShift('ﾞ', 'ボ', "bo", 'o', 'b'),
                new KanaPhoneticShift('ﾟ', 'ポ', "po", 'o', 'p')
            }),

            new Kana('マ', "ma", 'a', 'm'),
            new Kana('ミ', "mi", 'i', 'm'),
            new Kana('ム', "mu", 'u', 'm'),
            new Kana('メ', "me", 'e', 'm'),
            new Kana('モ', "mo", 'o', 'm'),

            new Kana('ヤ', "ya", 'a', 'y'),
            new Kana('ユ', "yu", 'u', 'y'),
            new Kana('ヨ', "yo", 'o', 'y'),

            new Kana('ラ', "ra", 'a', 'r'),
            new Kana('リ', "ri", 'i', 'r'),
            new Kana('ル', "ru", 'u', 'r'),
            new Kana('レ', "re", 'e', 'r'),
            new Kana('ロ', "ro", 'o', 'r'),

            new Kana('ン', "n", '\0', 'n'),

            new Kana('ワ', "wa", 'a', 'w'),
            new Kana('ヲ', "wo", 'o', 'w'),
        };

        public static IReadOnlyCollection<Kana> Collection => _katakana;
    }
}
