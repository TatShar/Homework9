// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Prompt (string sms)
{
    Console.Write(sms);
    int result = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    return result;
}
int sum = 0;
int Sum(int m,int n)
{
    if (m > n) 
    {
        return sum;  
    }
    else
    {
        sum = sum +m;
       return Sum(m+1,n);
    }
}
int m = Prompt("Введите число М: ");
int n = Prompt ("Введите число Н: ");
int sum1 = Sum(m,n);
Console.Write ("Cумма чисел от " + m + " до " +n+ " = " + sum1);