//Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string IntervalOfNumbers (int start, int stop)
{
    if (start == stop) return start.ToString();
    return (start + ", " + IntervalOfNumbers(start + 1, stop));
}

Console.Clear();
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (secondNumber > firstNumber)
{
    Console.WriteLine($"[ {IntervalOfNumbers(firstNumber, secondNumber)} ]");
}
else Console.WriteLine("Второе число должно быть больше первого");