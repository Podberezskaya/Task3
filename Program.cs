//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Input_array (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    array [i] = new Random().Next(100,1000);
}
int release(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array [i] % 2 == 0)
            count++;
    return count;
}
Console.Write("Введите колличество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array =new int [n];
Input_array(array);
Console.WriteLine($"[{string.Join(" , " , array)}]");
Console.WriteLine(release(array));
