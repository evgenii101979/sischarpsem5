// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
Console.Clear();
double[] mas = new double[6];
Random r = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = r.Next(-10, 10);
}
Console.WriteLine("Входной массив:" + "[ " + String.Join(", ", mas) + " ]");

Array.Sort(mas);
double maxValue = mas[mas.Length - 1];
Console.WriteLine("Максимальный элемент массива:" + "[ " + String.Join(", ", maxValue) + " ]");
double minValue = mas.Min();
Console.WriteLine("Минимальный элемент массива:" + "[ " + String.Join(", ", minValue) + " ]");
double result = maxValue - minValue;
Console.WriteLine("Разница между max и min:" + "[ " + String.Join(", ", result) + " ]");