// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void SecondNumber(int a)
{   
     string b = Convert.ToString(a);
     if(b.Length>2)
     {
        char[] ch = new char[b.Length]; 
        for (int i = 0; i < ch.Length; i++) { 
            ch[i] = b[i]; 
            } 
            Console.WriteLine(ch[2]);
     }
     else
     {
        Console.WriteLine("Введи число побольше в длину");
     }
}


Console.WriteLine("Воспользуемся функцией из предыдущей задачи, скорми мне число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
SecondNumber(a);

