public class ZigzagConversion{
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