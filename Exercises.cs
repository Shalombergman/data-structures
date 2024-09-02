namespace data_structures;

public class Exercises
{
    public static int[] Ex0CopyArray(int[] array)
    {
        int[] copy = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            copy[i] = array[i];
        }
        return copy;
    }
    
    public static int[] Ex1ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversed[i] = array[array.Length - 1 - i];
        }
        return reversed;
    }
}