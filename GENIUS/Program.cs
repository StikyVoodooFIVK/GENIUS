


void DataType:

while (true)
{
    Console.WriteLine("введите свой баланс: ");

    int amountOfmoney = Int32.Parse(Console.ReadLine());

    if (amountOfmoney <= 2000)
    {
        Console.WriteLine("Я богат, куплю 2 дошика вместо 1-го");
    }
    else if (amountOfmoney < 0)
    {
        Console.WriteLine("я бомж, у меня мало денег");
    }
    else
    {
        Console.WriteLine("нет денег, продам почку");
    }
}

