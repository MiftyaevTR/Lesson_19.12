//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Secondnumber(int number)
{
    int el = number/10;
    int result = el%10;
    
    return result;
}

Console.Write("Просьба ввести трехзначноечисло: " );
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Secondnumber(number));

*/
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Просьба введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string str = num.ToString();
int strLen = str.Length;

if (strLen<3) Console.WriteLine("Вы ввели слишком маленькое число. Просьба попробуйте снова");
else Console.WriteLine(str[strLen-3]);
 */

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekday(int num)
{
    if (num==6 || num ==7)
    {
        return true;
    } 
    else 
    {
        return false;
    }
}

Console.WriteLine ("Просьба введите число от 1 до 7!");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekday(num));
*/
