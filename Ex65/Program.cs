// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

ShowNNumbers(4,6);

void ShowNNumbers(int numberMin, int numberMax)
{
    if (numberMin > numberMax) return;
    else
    {
        Console.Write(numberMin + " ");
        ShowNNumbers(numberMin + 1, numberMax); // От 1 до N
        // Console.Write(numberMin + " ");
    }
}