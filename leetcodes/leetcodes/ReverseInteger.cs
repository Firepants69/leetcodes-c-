public class ReverseInteger {
    public int Reverse(int x) {
        try
        {
        checked {
            int reversed = 0;

            while (x != 0) {
                int digit = x % 10;
                x /= 10;
                reversed = reversed * 10 + digit;
            }

            return reversed;
        }
    
        }
        catch (System.OverflowException)
        {
            return 0;
        }
    }
}