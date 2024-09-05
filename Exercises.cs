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

    public static double Ex2AmounCalculationArray(int[] array)
    {
        float sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }

    public static int Ex3findMin(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[min] > array[i])
            {
                min = i + 1;
            }

        }

        return min;
    }

    public static int[] Ex4MargeTwoArry(int[] array1, int[] array2)
    {

        int i = 0, j = 0, len = array1.Length + array2.Length;
        int[] ans = new int[len];
        while (i <= array1.Length && j <= array2.Length)
        {
            if (array1[i] == array2[j])
            {
                ans[i + j] = array1[i];
                ans[i + j + 1] = array2[j];
            }

            if (array1[i] < array2[j])
            {
                ans[i + j] = array1[i++];
            }
            else
            {
                ans[i + j] = array2[j++];
            }
        }

        while (i < array1.Length)
        {
            ans[i + j] = array1[i++];
        }

        while (j < array2.Length)
        {
            ans[i + j] = array2[j++];
        }

        return ans;
    }

    public static int[] Ex5IncidenceGradse(int[] array1)
    {
        int[] ans = new int[array1.Length];
        int count = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = i; j < array1.Length; j++)
            {
                if (j == i)
                {
                    count += 1;
                }
            }

            ans[i] = count;
        }

        return ans;
    }

    public static double Ex6Averageלֹalculation(int[] array1)
    {
        double sum = Ex2AmounCalculationArray(array1);
        return sum / array1.Length;
    }

    public static int[] Ex7zigzagArr(int[] array1)
    {
        int[] ans = new int[array1.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1.Length % i == 0 && array1[i + 1] > array1[i])
            {
                int temp = array1[i];
                array1[i] = array1[i + 1];
                array1[i + 1] = temp;
            }

            if (array1.Length % i != 0 && array1[i + 1] < array1[i])
            {
                int temp = array1[i];
                array1[i] = array1[i + 1];
                array1[i + 1] = temp;
            }
        }

        return array1;
    }

    public static int[] Ex8SReturnArrNumToMorOneTimse(int[] array1)
    {
        int[] temp = Ex5IncidenceGradse(array1);
        int count = 0;
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] > 1)
            {
                count += 1;
            }
        }

        int[] ans = new int[count];
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i] > 1)
            {
                ans[i] = i;
            }
        }

        return ans;
    }

    public static int[,] Ex9SortMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[] temp = new int[rows * cols];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                temp[index++] = matrix[i, j];
            }
        }

        Array.Sort(temp);
        index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = temp[index];
            }

        }

        return matrix;

    }

    public static int CalculateOddSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                sum += array[i];
            }
        }

        return sum;
    }

    public static (int, int) FindMaximumTwo(int[] array)
    {
        int max1 = array[0];
        int max2 = array[1];
        int max = 0;
        for (int i = 0; i < array.Length; i++)
        {
            int j = i + 1;
            if (array[i] + array[j] > max)
            {
                max = array[i] + array[j];
                max1 = array[i];
                max2 = array[j];
            }
        }

        return (max1, max2);
    }

    public static bool ContainsNumber(int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                return true;
            }
        }

        return false;
    }

    public static void SumOfAllTriplets(int[] array)
    {

    }

}