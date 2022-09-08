//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int sum = 0;

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
Random rnd = new Random();

for (int i = 0; i<len; i++)
{
    array[i] = rnd.Next(100,1000);
}

for (int y = 0; y < len; y++)
    if (array[y] % 2 == 0) sum ++;

Console.Write("[{0}]", string.Join(", ", array));
Console.Write($" -> {sum}");