namespace data_structures;

public class SelactionSort
{
    public static int[] Sort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min = i;
            for (int j = i+1; j < n; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        return array;
    }
}