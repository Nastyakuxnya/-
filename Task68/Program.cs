//Задача 68:
//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine();
Console.WriteLine();
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunction(int m, int n)
{

    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return AckermanFunction(m - 1, 1);
        }

        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}

bool CheckRange(int numberM, int numberN)
{
    return (numberM > 3 &&  numberN >= 11) || ( numberM >= 4 && numberN > 0);
  
}

if (CheckRange(numberM, numberN))
{
    Console.WriteLine("Некорректный ввод, введите другие M и N");
    return;
}

int ack = AckermanFunction(numberM, numberN);
Console.WriteLine(ack);