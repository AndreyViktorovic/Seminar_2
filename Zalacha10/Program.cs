// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA > 99)
{
    if(numberA < 1000)
    {
        int firstDigit = (numberA / 10) % 10;
        Console.WriteLine($"Вторая цифра из числа {firstDigit}");
    }
    else
    {
        Console.WriteLine("Много цифр убавь");
    }
}
else
{
    Console.WriteLine("Мало цифер добавь");
}
// int number = Random.Shared.Next(100, 1000);
// Console.WriteLine($"Генерируемое трехзачное число {numberA}");
// int firstDigit = (numberA / 10) % 10;
// Console.WriteLine($"Вторая цифра из числа {firstDigit}");