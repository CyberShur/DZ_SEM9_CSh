/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

int numberN = Coordinate("N");
int numberM = Coordinate("M");
int sum = 0;

Console.WriteLine($"Сумма чисел от {numberN} до {numberM} равна: {OutrutFun(numberN, numberM, sum)}");

int OutrutFun(int num1, int num2, int sum)
{
    if(num1 <= num2)
    {
        sum += num1;
        num1++;
        return OutrutFun(num1, num2, sum);
    }
        return sum;
}

int Coordinate(string coorName)
{
    Console.Write($"Введите число {coorName}: "); 
    return Convert.ToInt32(Console.ReadLine());
}
