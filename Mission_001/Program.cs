// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
       mas[i] = new Random().Next(100, 1000); 
    }
}
void Print (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
       Console.Write(mas[i] + " "); 
    }
    Console.WriteLine();
}
int Sum(int[]mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i]%2 ==0)
        sum+=1;
    }
    return sum;     
}
int [] arr = new int [5];
Random(arr);
Print(arr);
Console.WriteLine($"Количество чётных чисел в массиве = {Sum(arr)}");

