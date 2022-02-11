namespace CayArpshay;

public static class Translator {
    private static readonly List<string> Vowels = new() {"a", "e", "i", "o", "u"};
    
    public static string Translate(string english) {
        string pigLatin;

        if (Vowels.Contains(english[0].ToString().ToLower())) {
            pigLatin = $"{english}way";
        } else {
            var firstVowelIndex = -1;
        
            for (var i = 0; i < english.Length; i++) {
                if (!Vowels.Contains(english[i].ToString())) continue;
                
                firstVowelIndex = i;
                break;
            }

            pigLatin = english[firstVowelIndex..] + english[..firstVowelIndex].ToLower() + "ay";

            if (IsCapitalized(english)) {
                pigLatin = pigLatin[0].ToString().ToUpper() + pigLatin[1..];
            }
        }

        return pigLatin;
    }

    private static bool IsCapitalized(string english) {
        return string.Equals(english[0].ToString(), english[0].ToString().ToUpper());
    }
}

