
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Просьба введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string str = num.ToString();

if (str[0]==str[4] && str[1]==str[3]) Console.WriteLine("Данное число является полиндромом");
else Console.WriteLine("Данное число не является полиндромом");
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cub (int num)
{
    int count = 1;
    while (count<num + 1)
    {
        Console.Write(count*count*count + " ");
        count=count+1;
    }
}

Console.Write("Просьба введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Cub(num);