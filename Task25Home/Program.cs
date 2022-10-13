/*Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

void GetGetDegree()
{
    Console.WriteLine("Введите число А:");
    int numA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число B:");
    int numB = int.Parse(Console.ReadLine());3
    
    double degree = 0;
    degree = Math.Pow(numA, numB);
    Console.WriteLine($"{numA},{numB}->{degree}");
}
GetGetDegree();
