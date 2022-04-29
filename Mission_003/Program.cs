// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next (-10,10);
    }
}
void Print(int[]mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i] + " ");
    }
    Console.WriteLine();
}
void MathAbs(int [] mas)
{
   int MinValue = mas[0];
   int MaxValue = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if (mas[i] < MinValue)
        {
            MinValue = mas[i];
        }
    
        if (mas[i] > MaxValue)
        {
            MaxValue = mas[i];
        }
    }
    Console.WriteLine($" Максимальное значение массива {MaxValue}");
    Console.WriteLine($" Минимальное значение массива {MinValue}");
    Console.WriteLine($" {MaxValue} - {MinValue} = {MaxValue-MinValue}");
}

int [] Arr = new int [7];
Random(Arr);
Print(Arr);
MathAbs(Arr);