namespace data_structures;


//O(n**2)
public class InsertSort
{
    public static int[] InsertionSort(int[] arr)
    {
        int i, j, temp;
        for ( i = 1; i < arr.Length; i++)
        {
            j = i - 1;
            temp = arr[i];
            while (j >= 0 && arr[j] > temp)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = temp;
        }
        return arr;
    }
    
}
