namespace Task4;

public class Car
{
    public string Make {get; set;}= string.Empty;
    public string Model {get;set;}=string.Empty;
    public int Year;
    public double Mileage = 0;
    public double Fuel = 0;

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;

    }
    public void Drive(double miles)
    {
       
        if(Fuel >= miles)
        {
            Fuel-=miles;
            Mileage+=miles;
        }
        else
        {
            System.Console.WriteLine("You dont have fuel");
        }
    }

    public void AddFuel(double gallons)
    {
        Fuel += gallons;
    }

}
