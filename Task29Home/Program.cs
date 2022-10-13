/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элементов через консоль (через запятую. использовать метод string.Split())
В C# Split () - это строковый класс метод. Метод Split() возвращает массив строк, 
сгенерированных разбиением исходной строки, разделенной разделителями, переданными 
в качестве параметра в методе Split ().*/

int[] ArraySplit(int n)
{
    int[] array = new int[n];
    int i;
    Console.WriteLine("Введите  массив из 8 элементов через запятую: ");
    string[] result = Console.ReadLine().Split(' ');
    Console.WriteLine($"{result[0]}->[{result[0]}]");
    Console.WriteLine($"{result[1]}->[{result[1]}]");
    for (i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int[] array = ArraySplit(8);
Console.WriteLine($"[{array[0]}] ");