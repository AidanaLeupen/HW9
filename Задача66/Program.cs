// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter number M: "); 
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: "); 
int numberN = Convert.ToInt32(Console.ReadLine());

int MN(int numberM, int numberN)
{
    int result = numberM;
    if (numberM == numberN) return 0;
    else
    {
        numberM++;
        result = numberM + MN(numberM, numberN);
        return result;
    }
}

void SumMN(int numberM, int numberN)
{
    Console.Write(MN(numberM - 1, numberN));
}

SumMN(numberM, numberN);