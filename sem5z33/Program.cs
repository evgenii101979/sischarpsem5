// Задача 33. Задайте массив. Напишите программу, которая определяет
// присутствует ли заданное число в массиве.
// 4; массив [6,7,9,-5,10,3] -> нет;
// -5; массив [6,7,9,-5,10,3] -> нет;
Console.Clear();
System.Console.WriteLine("Присутствует ли заданное число в массиве");
Console.WriteLine("\nВведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(8, -9, 9);
int[] FillArray(int size, int min, int max)
{
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

void NumArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        i == number;
    }

}
Console.WriteLine("Число " + number + " в массиве " + "[" + String.Join(",", array) + "]" + " есть");
Console.WriteLine("Число " + number + " в массиве " + "[" + String.Join(",", array) + "]" + " отсутствует");


доделать/////////////
