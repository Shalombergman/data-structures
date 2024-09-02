namespace data_structures;

public class Array1
{
    
    // a few ways to define arrays

    // 1 define an empty array with the size and type
    // bad
    public static int[] array1 = new int[10];
    public static char[] charArray = new char[10]; // default value '\0'
    
    //good
    public static int peopleAmount = 10;
    public static int[] ages = new int[peopleAmount];

    
    // 2 define an array hard coded
    public static int[] array2 = { 67, -7, 0, 50};
    public static String[] names = { "Omer", "Avi", "Yakov" };
    
    public static double CalculateAverage()
    {
        
        int[] arr = { 1, 2, 3, 4, 5 };
        int len = arr.Length;
        double sum = 0;
        for (int i = 0; i < len; i++)
        {
            sum += arr[i];
        }
        double average = sum / len;
        return average;
    }

    public static void InitArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
    }
}