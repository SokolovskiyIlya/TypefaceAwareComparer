using System.Text;

namespace TypefaceAwareComparer
{
    public static class Comparer
    {
        private static readonly Dictionary<char, char> _map = new Dictionary<char, char>
        {
            {'А', 'A'}, {'В', 'B'}, {'С', 'C'}, {'Е','E'}, {'Н', 'H'}, {'I','1'}, {'l','1'}, {'К','K'}, {'М', 'M'}, {'О', 'O'}, {'0','O'}, {'Р','P'}, {'Т', 'T'},
            {'Х','X'}, {'У','Y'}, {'а','a'}, {'с','c'}, {'е','e'}, {'п','n'}, {'о','o'}, {'р','p'}, {'и','u'}, {'х','x'}, {'у','y'}, {'З','3'}, {'б','6'}
        };

        private static string Normalize(string input)
        {
            var normalized = new StringBuilder(input.Length);
            foreach (var c in input)
            {
                normalized.Append(_map.TryGetValue(c, out var normalizedChar) ? normalizedChar : c);
            }
            return normalized.ToString();
        }

        public static bool CompareStrings(string str1, string str2)
        {
            return Normalize(str1) == Normalize(str2);
        }
    }
}