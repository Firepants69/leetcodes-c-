public class LengthOfLongestSubstring
{

    public int lengthOfLongestSubstring(string s)
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

// Para este ejercicio use un set el cual no puede contener valores repetidos
// para la resolucion del problema se utilizo la tecnica de la ventana deslizante o 
// slide window el while sirve para elminar los caracteres anteriores y actual al char repetido
