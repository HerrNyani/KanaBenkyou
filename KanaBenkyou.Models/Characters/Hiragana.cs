using System.Collections.Generic;

namespace HerrNyani.KanaBenkyou.Models.Characters
{
    public static class Hiragana
    {
        private static readonly List<Kana> _hiragana = CreateHiraganaList();

        public static IReadOnlyCollection<Kana> Collection => _hiragana;

        private static List<Kana> CreateHiraganaList()
        {
            return new List<Kana>
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

                new Kana('は', "ha", 'a', 'h', new List<KanaPhoneticShift> {
                    new KanaPhoneticShift('ﾞ', 'ば', "ba", 'a', 'b'),
                    new KanaPhoneticShift('ﾟ', 'ぱ', "pa", 'a', 'p')
                }),
                new Kana('ひ', "hi", 'i', 'h', new List<KanaPhoneticShift> {
                    new KanaPhoneticShift('ﾞ', 'び', "bi", 'i', 'b'),
                    new KanaPhoneticShift('ﾟ', 'ぴ', "pi", 'i', 'p')
                }),
                new Kana('ふ', "fu", 'u', 'h', new List<KanaPhoneticShift> {
                    new KanaPhoneticShift('ﾞ', 'ぶ', "bu", 'u', 'b'),
                    new KanaPhoneticShift('ﾟ', 'ぷ', "pu", 'u', 'p')
                }),
                new Kana('へ', "he", 'e', 'h', new List<KanaPhoneticShift> {
                    new KanaPhoneticShift('ﾞ', 'べ', "be", 'e', 'b'),
                    new KanaPhoneticShift('ﾟ', 'ぺ', "pe", 'e', 'p')
                }),
                new Kana('ほ', "ho", 'o', 'h', new List<KanaPhoneticShift> {
                    new KanaPhoneticShift('ﾞ', 'ぼ', "bo", 'o', 'b'),
                    new KanaPhoneticShift('ﾟ', 'ぽ', "po", 'o', 'p')
                }),

                new Kana('な', "na", 'a', 'n'),
                new Kana('に', "ni", 'i', 'n'),
                new Kana('ぬ', "nu", 'u', 'n'),
                new Kana('ね', "ne", 'e', 'n'),
                new Kana('の', "no", 'o', 'n'),

                new Kana('た', "ta", 'a', 't', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'だ', "da", 'a', 'd'),
                }),
                new Kana('ち', "chi", 'i', 't', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ぢ', "ji", 'i', 'd'),
                }),
                new Kana('つ', "tsu", 'u', 't', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'づ', "zu", 'u', 'd'),
                }),
                new Kana('て', "te", 'e', 't', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'で', "de", 'e', 'd'),
                }),
                new Kana('と', "to", 'o', 't', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ど', "do", 'o', 'd'),
                }),

                new Kana('さ', "sa", 'a', 's', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ざ', "za", 'a', 'z'),
                }),
                new Kana('し', "shi", 'i', 's', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'じ', "ji", 'i', 'z'),
                }),
                new Kana('す', "su", 'u', 's', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ず', "zu", 'u', 'z'),
                }),
                new Kana('せ', "se", 'e', 's', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ぜ', "ze", 'e', 'z'),
                }),
                new Kana('そ', "so", 'o', 's', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ぞ', "zo", 'o', 'z'),
                }),

                new Kana('か', "ka", 'a', 'k', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'が', "ga", 'a', 'g'),
                }),
                new Kana('き', "ki", 'i', 'k', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ぎ', "gi", 'i', 'g'),
                }),
                new Kana('く', "ku", 'u', 'k', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ぐ', "gu", 'u', 'g'),
                }),
                new Kana('け', "ke", 'e', 'k', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'げ', "ge", 'e', 'g'),
                }),
                new Kana('こ', "ko", 'o', 'k', new List<KanaPhoneticShift>{
                    new KanaPhoneticShift('ﾞ', 'ご', "go", 'o', 'g'),
                }),

                new Kana('あ', "a", 'a', '\0'),
                new Kana('い', "i", 'i', '\0'),
                new Kana('う', "u", 'u', '\0'),
                new Kana('え', "e", 'e', '\0'),
                new Kana('お', "o", 'o', '\0'),
            };
        }
    }
}
