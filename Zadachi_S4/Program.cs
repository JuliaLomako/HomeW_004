//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

double NumpoW(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

Console.WriteLine("Введите первое целое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int numВ = Convert.ToInt32(Console.ReadLine());
if (numВ < 1 || numA < 1) Console.WriteLine("невозможно выполнить операцию, так как одно из чисел является ненатрульным либо равно нулю");
else Console.WriteLine($"первое число {numA} в степени второго числа {numВ} равна {NumpoW(numA, numВ)}");


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int NumSum(int number)
{
    int result = 0;
    number = Math.Abs(number);
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.WriteLine("Введите целое число");
int numZ = Convert.ToInt32(Console.ReadLine());
if (numZ < 1) Console.WriteLine("Введено отрицательное число");
else Console.WriteLine($"сумма цифр в числе {numZ} равна {NumSum(numZ)}");


//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void ArrayNum()
{
    int[] massiv = new int[8];
    for (int i = 0; i < 8; i++)
    {
        massiv[i] = new Random().Next(1, 9);
        Console.Write(massiv[i] + " ");
    }

}

ArrayNum();
