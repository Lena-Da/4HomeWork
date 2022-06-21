// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введи число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int answer = 1;

for(int i=1;i<=b;i++)
{
    answer = answer * a;
}

Console.WriteLine(answer);