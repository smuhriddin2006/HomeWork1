using System.Diagnostics.CodeAnalysis;

namespace Task3;

public class Student
{
    public string Name {get; set;}=string.Empty;
    public int GradeLevel {get; set;}
    public List<double> Scores = new();

    public double GetAverage()
    {
        double sum = 0;
        double ave = 0;
        foreach(double res in Scores)
        {
            sum+=res;
            ave = sum / Scores.Count();
        }

        if(ave > 85)
        {
            System.Console.Write($"{Name} you doing great your average is {ave} in grade ");
        }

        else if(ave < 70)
        {
            System.Console.Write($"{Name} you need to work harder your average is {ave} in grade ");
        }

                else if(ave >= 70 && ave <= 85)
        {
            System.Console.Write($"{Name} you need to work harder your average is {ave} in grade ");
        }
       return GradeLevel;
    }
    

}
