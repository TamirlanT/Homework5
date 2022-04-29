// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void Random (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
      mas[i] = new Random().Next(-10,10);  
    }
}
void Print (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine(mas[i] + " ");
    }
    Console.WriteLine();
}
int Sum(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length;)
    {
        sum = sum + mas[i];
        i = i+2;
    }
    return sum;
}
int [] Arr = new int[7];
Random(Arr);
Print(Arr);
Console.WriteLine($"Сумма нечетных элементов массива = {Sum(Arr)}");
