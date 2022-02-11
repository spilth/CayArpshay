using CayArpshay;

if (args.Length == 1 && args[0].Length > 0) {
    Console.WriteLine(Translator.Translate(args[0]));
} else {
    Console.WriteLine("Please pass a word to translate.");
}
