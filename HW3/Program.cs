/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9  */

int numberM = Coordinate("M");
int numberN = Coordinate("N");

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Функция Аккермана работает только с положительными числами.");
}
else
{
    Console.WriteLine(AckermannFunction(numberM, numberN));
}

int AckermannFunction(int num1, int num2)
{
    if (num1 == 0) 
    {
        return num2 + 1;
    }
    else if (num1 > 0 && num2 == 0)
    {
        return AckermannFunction(num1 - 1, 1);
    }  
    else if (num1 > 0 && num2 > 0) 
    {
        return AckermannFunction(num1 - 1, AckermannFunction(num1, num2 - 1));
    }
    else
    {
        return AckermannFunction(num1,num2);
    }
}

int Coordinate(string coorName)
{
    Console.Write($"Введите число {coorName}: "); 
    return Convert.ToInt32(Console.ReadLine());
}