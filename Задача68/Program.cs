// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter number M: "); 
int numberM = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number N: "); 
int numberN = Convert.ToInt32(Console.ReadLine());

void AF(int numberM, int numberN)
{
    Console.Write(A(numberM, numberN));
}

int A(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM > 0 && numberN == 0) return A(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return (A(numberM - 1, A(numberM, numberN - 1)));
    else 
    return 0; 
}

AF(numberM, numberN);