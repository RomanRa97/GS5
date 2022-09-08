//Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int raz = 0;
int max = 0;

Console.WriteLine("Введите длинну массива");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
Random rnd = new Random();

for (int i = 0; i<len; i++)
{
    array[i] = rnd.Next(1,100);
}

for (int y = 0; y < len; y++)
    if (array[y] > max) max = array[y];

int min = max;
for (int y = 0; y < len; y++)
    if (array[y] < min) min = array[y]; 

raz = max-min;

Console.Write("[{0}]", string.Join(", ", array));
Console.Write($" -> {raz}");