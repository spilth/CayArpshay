using CayArpshay;
using NUnit.Framework;

namespace ClassLibTests;

public class TranslatorTests {
    [Test]
    public void WordsStartingWithLowercaseVowels() {
        Assert.That(Translator.Translate("apple"), Is.EqualTo("appleway"));
        Assert.That(Translator.Translate("orange"), Is.EqualTo("orangeway"));
    }
    
    [Test]
    public void WordsStartingWithLowercaseConsonants() {
        Assert.That(Translator.Translate("computer"), Is.EqualTo("omputercay"));
        Assert.That(Translator.Translate("programming"), Is.EqualTo("ogrammingpray"));
        Assert.That(Translator.Translate("string"), Is.EqualTo("ingstray"));
    }
}
