public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));

    }

    public static int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 1) return 1;

        int maxLengthSubstring = 0;
        int left = 0;
        HashSet<char> originalKeys = new HashSet<char>();
        for (int right = 0; right < s.Length; right++)
        {
            while (originalKeys.Contains(s[right]))
            {
                originalKeys.Remove(s[left++]);
                Console.WriteLine("se ejecuto esto");
            }
            originalKeys.Add(s[right]);
            maxLengthSubstring = Math.Max(maxLengthSubstring, originalKeys.Count);
        }
        return maxLengthSubstring;
    }
}