// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите цифру"); 
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString); 

if (numberInt > 8 || numberInt < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (numberInt < 5 && numberInt > 0)
    {
    Console.WriteLine("Нет");
    }
    else
    {
        if (numberInt == 6)
        {
            Console.WriteLine("Суббота");
        }
                if (numberInt == 7)
                {
                    Console.WriteLine("Воскресенье");
                }
    }
}
