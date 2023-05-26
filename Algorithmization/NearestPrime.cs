using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        } 
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static int NearestPrime(int num)
    {
        if (num <= 1)
        {
            return 2;
        }
        if (num == 2)
        {
            return 3;
        }
        int nearprimeless = int.MinValue;
        for (int i = 2; i < num; i++)
        {
            if (IsPrime(i))
            {
                if (i > nearprimeless)
                {
                    nearprimeless = i;
                }
            }
        }
        int nearprimemore = int.MaxValue;
        for (int i = num*2; i > num; i--)
        {
            if (IsPrime(i))
            {
                if (i < nearprimemore)
                {
                    nearprimemore = i;
                }
            }
        }
        if (num - nearprimeless < nearprimemore - num)
        {
            return nearprimeless;
        }
        if (num - nearprimeless > nearprimemore - num)
        {
            return nearprimemore;
        }
        else
        {
            return nearprimemore;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32 (Console.ReadLine());
        int nearestprime = NearestPrime(num);
        Console.WriteLine($"Nearest prime is {nearestprime}");
    }
}