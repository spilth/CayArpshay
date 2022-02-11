namespace CayArpshay;

public static class Translator {
    private static readonly List<string> Vowels = new() {"a", "e", "i", "o", "u"};
    
    public static string Translate(string english) {
        string pigLatin;

        if (Vowels.Contains(english[0].ToString())) {
            pigLatin = $"{english}way";
        } else {
            var firstVowelIndex = -1;
        
            for (var i = 0; i < english.Length; i++) {
                if (!Vowels.Contains(english[i].ToString())) continue;
                
                firstVowelIndex = i;
                break;
            }

            pigLatin = english[firstVowelIndex..] + english[..firstVowelIndex] + "ay";
        }

        return pigLatin;
    }
}

