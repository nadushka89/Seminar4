/*Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

void GetNumber()
{
    Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    string numAsString = number.ToString();
    int sum = 0;
    int length = numAsString.Length;
    for (int i = 0; i < length; i++)
    {
        sum += int.Parse(numAsString[i].ToString());
    }
    Console.WriteLine($"{number}->{sum}");
}
GetNumber();
