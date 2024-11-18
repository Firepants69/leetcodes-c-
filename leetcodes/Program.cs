public class Program
{
    static void Main(string[] args)
    {

        string s = "abcabcbb";
        Console.Write(LengthOfLongestSubstring(s));


    }

    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;

        int maxLengthSubstring = 0;
        int begin = 0;
        HashSet<char> originalKeys = new HashSet<char>();

        for (int end = 0; end < s.Length; end++)
        {
            if (originalKeys.Contains(s[end]))
            {
                begin = end;
            }
            originalKeys.Add(s[end]);

            if (end - begin > maxLengthSubstring)
            {
                maxLengthSubstring = end - begin;
            }
            Console.WriteLine(end);
        }
        Console.WriteLine(begin);
        return maxLengthSubstring;
    }
}