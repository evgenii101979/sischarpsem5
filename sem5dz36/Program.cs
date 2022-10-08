// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


Console.Clear();
int[] array = FillArray(6, 1, 10);
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
int result = 0;
for (int i = 1; i < array.Length; i++)
{
    int element = array[i];
    result = array[i++] + result;
}

System.Console.WriteLine("сумма элементов на нечётных позициях = " + result);