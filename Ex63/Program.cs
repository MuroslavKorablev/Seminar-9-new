// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
System.Console.WriteLine(ShowNumbers(5));
ShowNNumbers(6);

string ShowNumbers(int number)
{
    if (number == 1) return "1 ";
    // else return $"{number} " + ShowNumbers(number - 1); // От N до 1
    else return ShowNumbers(number - 1) + $"{number} "; // От 1 до N
}

void ShowNNumbers(int number)
{
    if (number == 0) return;
    else
    {
        // Console.Write(number + " "); // От N до 1
        ShowNNumbers(number - 1); // От 1 до N
        Console.Write(number + " ");
    }
}
