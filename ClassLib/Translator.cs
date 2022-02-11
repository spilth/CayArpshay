namespace CayArpshay;

public static class Translator {
    private static readonly List<string> Vowels = new() {"a", "e", "i", "o", "u"};
    
    public static string Translate(string english) {
        var firstVowelIndex = 0;

        while (IsConsonant(english[firstVowelIndex])) {
            firstVowelIndex++;
        }

        var pigLatin = english[firstVowelIndex..] + english[..firstVowelIndex].ToLower();

        if (IsCapitalized(english)) {
            pigLatin = pigLatin[0].ToString().ToUpper() + pigLatin[1..];
        }

        if (firstVowelIndex == 0) {
            return pigLatin + "way";
        }

        return pigLatin + "ay";
    }

    private static bool IsCapitalized(string english) {
        return string.Equals(english[0].ToString(), english[0].ToString().ToUpper());
    }

    private static bool IsConsonant(char character) {
        return !Vowels.Contains(character.ToString().ToLower());
    }
}

