﻿
void Condition()
{






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
            Console.WriteLine("я бомж, у меня мало денег, пойду далше");
        }
        else
        {
            Console.WriteLine("нет денег, продам почку");
        }
    }

}

int i = 0;  


// Цикл с предусловием
while(i < 5)
{

    Console.WriteLine(i);
    i++;
}


// Цикл с постусловием
do
{ 

    i++;
    Console.WriteLine(i);


}while (i<0);


// Цикл for

for (i = 0; i < 52; i++)
{
    
}

int result;
int mnojitel  = 5;
for ( i = 0; i < 11; i++)
{
    result = i * mnojitel;
    Console.WriteLine(result);
}




int[] numbers;
int[] numbers_1 = new int[10];


// определение n-мерных массивов

int[] matrix = new int[3, 3] { { 1, 2, 3, } { 4, 5, 6, } { 7, 8, 9, } };


foreach (int a in numbers_1)
{
    Console.WriteLine(a);
}

