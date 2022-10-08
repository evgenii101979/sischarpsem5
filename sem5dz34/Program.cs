// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
int[] array = FillArray(4, 100, 1000);
System.Console.WriteLine("Входной массив:" + "[ " + String.Join(", ", array) + " ]");
int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}
int[] colArray = array;
int result = 0;
for (int i = 0; i < colArray.Length; i++)
{
    if (colArray[i] % 2 == 0)
    {
        result ++;
    }
}
System.Console.WriteLine("количество чётных чисел в массиве " + result);

