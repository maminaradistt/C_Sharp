using System;

class Program
{
    static int Gcd(int firstnum, int secondnum, int thirdnum)
    {
        if (firstnum < secondnum)
        {
            int temp = firstnum;
            firstnum = secondnum;
            secondnum = temp;
        }
        if (firstnum < thirdnum)
        {
            int temp = firstnum;
            firstnum = thirdnum;
            thirdnum = temp;
        }
        if (secondnum < thirdnum)
        {
            int temp = secondnum;
            secondnum = thirdnum;
            thirdnum = temp;
        }
        while (thirdnum != 0)
        {
            int temp = firstnum % thirdnum;
            firstnum = secondnum;
            secondnum = thirdnum;
            thirdnum = temp;
        }
        return secondnum;
    }
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int firstnum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int secondnum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int thirdnum = Convert.ToInt32(Console.ReadLine());
        int gcd = Gcd(firstnum, secondnum, thirdnum);
        Console.WriteLine($"The GCD is {gcd}");
    }
}