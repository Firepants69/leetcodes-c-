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

// d es lo que le indica subir o bajar a niveles en el arreglo de strings
// cuando llega a i a valer lo mismo que el numsRows-1 sube osea d = -1
// cuando llega a i a valer 0 baja osea d = 1
