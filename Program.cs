// See https://aka.ms/new-console-template for more information


using data_structures;

int num1 = 1;
int num2 = 1;
Console.WriteLine(num1 == num2);
int[] arr1 = { 17, 80, 67 };
int[] arr2 = { 1, 2 };
Console.WriteLine(arr1 == arr2);
Console.WriteLine(arr1[2]);

Console.WriteLine(Array1.CalculateAverage());

int size = 15;
int[] arr20 = new int[size];
Array1.InitArray(arr20);

int num3 = 100;


//              variable    value
//                num1        1
//                num2        1
//                arr1       00x0    
//                arr2       00x8   



// 00x0          arr1        17
// 00x4                      80
// 00x8                      67
// 00x12         arr2         1
// 00x12                      2
