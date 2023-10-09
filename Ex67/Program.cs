// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


ShowNNumbers(45);
System.Console.WriteLine(SumOfDigit(453));
void ShowNNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;  // Получаем последнюю цифру числа
        sum += digit;             // Прибавляем цифру к сумме
        number /= 10;             // Удаляем последнюю цифру из числа
    }
    System.Console.WriteLine(sum);
}

int SumOfDigit(int num)
{
    if (num == 0) return num;
    else return num % 10 + SumOfDigit(num / 10);
}