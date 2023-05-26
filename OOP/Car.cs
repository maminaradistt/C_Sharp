using System;

class Car
{
    private string name;
    private double max_speed;

    public Car(string name, double max_speed)
    {
        this.name = name;
        this.max_speed = max_speed;
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public double MaxSpeed
    {
        get
        {
            return max_speed;
        }
        set
        {
            max_speed = value;
        }
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter name of the first car: ");
        string name1 = Console.ReadLine();
        Console.WriteLine("Enter max speed of the first car: ");
        double max_speed1 = Convert.ToDouble(Console.ReadLine());
        Car Car1 = new Car(name1, max_speed1);
        Console.WriteLine("Enter name of the second car: ");
        string name2 = Console.ReadLine();
        Console.WriteLine("Enter max speed of the second car: ");
        double max_speed2 = Convert.ToDouble(Console.ReadLine());
        Car Car2 = new Car(name2, max_speed2);
        if (Car1.MaxSpeed > Car2.MaxSpeed)
        {
            Console.WriteLine($"Max speed of car called {Car1.Name} is {Car1.MaxSpeed - Car2.MaxSpeed} kilometers per hour higher");
        }
        if (Car1.MaxSpeed < Car2.MaxSpeed)
        {
            Console.WriteLine($"Max speed of car called {Car2.Name} is {Car2.MaxSpeed - Car1.MaxSpeed} kilometers per hour higher");
        }
    }
}