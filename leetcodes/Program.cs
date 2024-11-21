public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Convert("PAYPALISHIRING",3));
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
    public static string Convert(string s, int numRows) {
        if(numRows ==1) return s;

        string result = "";
        
        string [] mat = new string[numRows];
        int i =0;
        int d =1;

        foreach(char c in s){
            mat[i] += c;
            if (i == 0){
                d = 1;
            }else if(i == numRows-1){
                d = -1;
            }
            i += d;
        }
        for(int j = 0;j<mat.Length;j++){
            result+= mat[j];
        }
       
        
        return result;        
    }
   
}