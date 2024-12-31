public class MyAtoi
{
    public int Myatoi(string s)
    {
        int sign = 1;
        int res = 0;
        int idx = 0;

        // ignora los espacios en blanco
        while (idx < s.Length && s[idx] == ' ')
        {
            idx++;
        }

        if (idx < s.Length && (s[idx] == '-' || s[idx] == '+'))
        {
            if (s[idx] == '-')
                sign = -1;
            idx++;
        }

        while (idx < s.Length && s[idx] >= '0' && s[idx] <= '9')
        {
            if (res > Int32.MaxValue / 10 ||
                (res == Int32.MaxValue / 10 && s[idx] - '0' > 7))
            {
                return sign == 1 ? Int32.MaxValue : Int32.MinValue;
            }
            res = 10 * res + (s[idx] - '0');
            idx++;
        }

        return res * sign;
    }
}