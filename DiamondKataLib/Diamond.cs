using System.Linq;

namespace DiamondKataLib;

public static class Diamond
{
    public static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static string[] Create(char to)
    {
        var idx = Alphabet.IndexOf(to);
        if(idx == -1)
            throw new ArgumentException("Specified character is not supported.", nameof(to));

        var start = Alphabet.Substring(0, idx);
        var end = start.Reverse();

        var chars = start.Append(to).Concat(end).ToArray();

        return chars.Select(CreateRow(chars.Length)).ToArray();
    }

    private static Func<char,string> CreateRow(int width)
    {
        return c =>
        {
            if (c == 'A')
            {
                var pad = new string(' ', width / 2);
                return $"{pad}A{pad}";
            }

            var intPadIdx = Alphabet.IndexOf(c);
            var intPadLen = Math.Max((intPadIdx * 2) - 1, 0);
            var intPad = new string(' ', intPadLen);

            var extPadLen = width - 2 - intPadLen;
            var extPad = new string(' ', extPadLen / 2);

            return $"{extPad}{c}{intPad}{c}{extPad}";
        };
    }


}
