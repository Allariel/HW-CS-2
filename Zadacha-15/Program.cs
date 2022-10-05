// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Day(int a)
{
    if((a==7) || (a==6))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("НЕ выходной");
    }
}



Console.WriteLine("Введи число");
int a = Convert.ToInt32(Console.ReadLine());
while( (a>7) || (a<1))
{
    a = Convert.ToInt32(Console.ReadLine());
} 
Day(a);