//Задайте одномерный массив, заполненный случайными числами. Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).

//[3, 7, 23, 12] -> 12
//[4, 6, 8, 1, 4] -> 6

int sum = 0;

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
Random rnd = new Random();

for (int i = 0; i<len; i++)
{
    array[i] = rnd.Next(1,100);
}

for (int y = 0; y < len; y+=2)
    if (array[y] % 2 == 0) sum += array[y];

Console.Write("[{0}]", string.Join(", ", array));
Console.Write($" -> {sum}");