// Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

// без методов

// int[] array = FillArray(4, -5, 9);
// int[] FillArray(int size, int min, int max)
// {
//     int[] filledArray = new int[size];

//     for (int i = 0; i < filledArray.Length; i++)
//     {
//         filledArray[i] = new Random().Next(min, max + 1);
//     }
//     return filledArray;
// }

// Console.WriteLine("[" + String.Join(",",array)+ "]");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] *-1; // каждый элемент массива * -1
// }
// Console.WriteLine("[" + String.Join(",",array)+ "]");

// с методами

System.Console.WriteLine("Замена элементов массива на противоположный знак");
int arr_length = 4;
int[] filledArray1 = FillArray(arr_length, -10, 10);
System.Console.WriteLine("\nРазмер массива\n {0}", arr_length);
System.Console.WriteLine("\nИсходный массив");
PrintArray(filledArray1);
ChangeArr(filledArray1);
System.Console.WriteLine("\nИзмененный массив:");
PrintArray(filledArray1);

int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}
void PrintArray(int[] arr)
{
    Console.WriteLine("[" + String.Join(",", arr) + "]");
}
void ChangeArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
}