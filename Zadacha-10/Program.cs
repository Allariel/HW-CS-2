//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//1 способ, простой.


int SecondNumber(int a)
{
     a = (a / 10) % 10;
    return a;
}


Console.WriteLine("Скорми мне число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
a = SecondNumber(a);
Console.WriteLine(a);




//2 cпособ, через массив. 

/*

char SecondNumber(int a)
{   
     string b = Convert.ToString(a);
     char[] ch = new char[b.Length]; 
    for (int i = 0; i < ch.Length; i++) { 
            ch[i] = b[i]; 
        } 
     return ch[1];
}



Console.WriteLine("Скорми мне число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
char second_number = SecondNumber(a);
Console.WriteLine(second_number);

*/