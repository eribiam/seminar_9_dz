//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfNumbers (int start, int stop)
{
    int resultSum = start;
    if (start == stop) return resultSum;
    return (resultSum + SumOfNumbers(start + 1, stop));
}

Console.Clear();
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber > firstNumber)
{
    Console.Write($"Сумма чисел от {firstNumber} до {secondNumber} = ");
    Console.WriteLine(SumOfNumbers(firstNumber, secondNumber));
}
else Console.WriteLine("Второе число должно быть больше первого");