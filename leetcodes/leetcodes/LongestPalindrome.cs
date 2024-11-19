public class LongestPalindrome{
     private static bool isPalindrome(string palindrome){
        bool isPalindrome = false;
        int j = palindrome.Length-1;
        for(int i = 0; i < palindrome.Length;i++){
            isPalindrome = palindrome[i] == palindrome[j];
            if(!isPalindrome){
                return isPalindrome;
            }
            j--;            
        }
        return isPalindrome;
    }
    public static string longestPalindrome(string s) {
        if(s.Length == 1) return s;

        string maxPalindromic = "";

        for(int i = 0; i< s.Length; i++){
            for(int j = i+1; j < s.Length+1;j++){
                string substring = s.Substring(i,j-i);
                Console.WriteLine(substring);
                maxPalindromic = isPalindrome(substring) && maxPalindromic.Length < substring.Length? substring:maxPalindromic;     
            }            
        }
        return maxPalindromic;
    }
}
// triple recursion == mala optimizacion