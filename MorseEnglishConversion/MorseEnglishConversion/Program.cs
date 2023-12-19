using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

//var text1 = "- .... .   .-- .. --.. .- .-. -..   --.- ..- .. -.-. -.- .-.. -.--   .--- .. -. -..- . -..   - .... .   --. -. --- -- . ...   -... . ..-. --- .-. .   - .... . -.--   ...- .- .--. --- .-. .. --.. . -.. .-.-.-";
//Console.WriteLine(Convert(true, text1));

var text2 = "The wizard quickly jinxed the gnomes before they vaporized.";
Console.WriteLine(Convert(false, text2));

static string Convert(bool morseToEnglish, string textToTranslate)
{
    if (string.IsNullOrEmpty(textToTranslate))
    {
        return "Invalid Morse Code Or Spacing";
    }

    var morseCodes = new Dictionary<string, string>();

    morseCodes.Add("a", ".-");
    morseCodes.Add("b", "-...");
    morseCodes.Add("c", "-.-.");
    morseCodes.Add("d", "-..");
    morseCodes.Add("e", ".");
    morseCodes.Add("f", "..-.");
    morseCodes.Add("g", "--.");
    morseCodes.Add("h", "....");
    morseCodes.Add("i", "..");
    morseCodes.Add("j", ".---");
    morseCodes.Add("k", "-.-");
    morseCodes.Add("l", ".-..");
    morseCodes.Add("m", "--");
    morseCodes.Add("n", "-.");
    morseCodes.Add("o", "---");
    morseCodes.Add("p", ".--.");
    morseCodes.Add("q", "--.-");
    morseCodes.Add("r", ".-.");
    morseCodes.Add("s", "...");
    morseCodes.Add("t", "-");
    morseCodes.Add("u", "..-");
    morseCodes.Add("v", "...-");
    morseCodes.Add("w", ".--");
    morseCodes.Add("x", "-..-");
    morseCodes.Add("y", "-.--");
    morseCodes.Add("z", "--..");

    morseCodes.Add("1", ".----");
    morseCodes.Add("2", "..---");
    morseCodes.Add("3", "...--");
    morseCodes.Add("4", "----.");
    morseCodes.Add("5", ".....");
    morseCodes.Add("6", ".----");
    morseCodes.Add("7", "--...");
    morseCodes.Add("8", "---..");
    morseCodes.Add("9", "----.");

    morseCodes.Add(".", ".-.-.-");
    morseCodes.Add(",", "--..--");
    morseCodes.Add("?", "..--..");

    var translatedText = new StringBuilder();

    if (morseToEnglish)
    {
        var words = textToTranslate.Split("   ");

        foreach (var word in words)
        {
            var letters = word.Split(" ");

            for (int i = 0; i < letters.Length; i++)
            {
                var letter = letters[i];

                var value = morseCodes.FirstOrDefault(x => x.Value == letter).Key;

                if (value != null)
                {
                    translatedText.Append(value);
                }
                else
                    return "Invalid Morse Code Or Spacing";
            }

            translatedText.Append(" ");
        }
    }
    else
    {
        var words = textToTranslate.Split(" ");

        foreach (var word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                var letter = word[i].ToString().ToLower();

                var value = morseCodes[letter];

                if (value != null)
                {
                    if (translatedText.ToString().Length == 0)
                        translatedText.Append(value);
                    else
                        translatedText.Append(" " + value);
                }
                else
                    return "Invalid Morse Code Or Spacing";

            }

            translatedText.Append("  ");
        }
    }

    return translatedText.ToString();
}


