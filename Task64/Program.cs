// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.



int PrintNumbers (int start, int and)
{
    
    if (start == and+1) return start;
        Console.Write($"{start}");
        return PrintNumbers (start+1, and);
}
Console.Write ("Введите число М: ");
int m = Math.Abs(int.Parse(Console.ReadLine()));
Console.Write ("Введите число М: ");
int n = Math.Abs(int.Parse(Console.ReadLine()));

PrintNumbers(m,n);