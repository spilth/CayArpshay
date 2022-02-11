using CayArpshay;
using NUnit.Framework;

namespace ClassLibTests;

public class TranslatorTests {
    [Test]
    public void WordsStartWithLowercaseVowels() {
        Assert.That(Translator.Translate("apple"), Is.EqualTo("appleway"));
    }
}
