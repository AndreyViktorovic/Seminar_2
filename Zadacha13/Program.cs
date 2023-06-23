// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
if(numberA > 99)
{
    if (numberA < 999 && numberA > 100)
    {
    int numberB = numberA % 10;
    Console.WriteLine($"Третьей цифрой заданого числа {numberB}");
    }
        if (numberA < 9999 && numberA > 1000)
        {
        int numberD = (numberA / 10) % 10;
        Console.WriteLine($"Третьей цифрой заданого числа {numberD}");
        }
            if (numberA < 99999 && numberA > 10000)
            {
            int numberC = (numberA / 100) % 10;
            Console.WriteLine($"Третьей цифрой заданого числа {numberC}");
            }
                if (numberA < 999999 && numberA > 100000)
                {
                int numberV = (numberA / 1000) % 10;
                Console.WriteLine($"Третьей цифрой заданого числа {numberV}");
                }
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
