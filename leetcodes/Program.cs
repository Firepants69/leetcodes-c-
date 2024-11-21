public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Reverse(200));
    }
// P   A   H   N
// A P L S I I G
// Y   I   R
// And then read line by line: "PAHNAPLSIIGYIR"

// Write the code that will take a string and make this conversion given a number of rows:

// string convert(string s, int numRows);
 

// Example 1:

// Input: s = "PAYPALISHIRING", numRows = 3
// Output: "PAHNAPLSIIGYIR"
    public static int Reverse(int x) {
        try
        {
        string xString = x.ToString();
        string rString = "";
        bool isNegative = false;

        for(int i =xString.Length-1;i>=0;i--){
            if(xString[i] != '-'){
                rString+=xString[i];
            }else{
                isNegative = true;
            }
        }       
        return isNegative ? Int32.Parse(rString)* (-1):Int32.Parse(rString);
    
        }
        catch (System.OverflowException)
        {
            return 0;
        }
        
    }
   
}