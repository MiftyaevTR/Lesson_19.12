
//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Write("Просьба введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

string str = num.ToString();

if (str[0]==str[4] && str[1]==str[3]) Console.WriteLine("Данное число является полиндромом");
else Console.WriteLine("Данное число не является полиндромом");
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Clear();
double Distance(double x1, double y1, double z1,
                double x2, double y2, double z2)
{
    double dis = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));
    return dis;
}

Console.Write("Введите координаты первой точки: ");
double x1 =Convert.ToDouble(Console.ReadLine());
double y1 =Convert.ToDouble(Console.ReadLine());
double z1 =Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй точки: ");
double x2 =Convert.ToDouble(Console.ReadLine());
double y2 =Convert.ToDouble(Console.ReadLine());
double z2 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между точками " + Distance(x1, y1, z1, x2, y2, z2 ));
 

*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
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
*/

