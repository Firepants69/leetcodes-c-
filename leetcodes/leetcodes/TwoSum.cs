public class TwoSum
{
    public int[] twoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        return result;
    }
}

// doble for para verificar todas las posibilidades de las sumas
