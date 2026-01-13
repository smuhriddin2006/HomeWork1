using System.Runtime.ConstrainedExecution;
using Task1;

Person person1 = new();
System.Console.Write("Enter a name: ");
person1.FirsName = System.Console.ReadLine();
System.Console.Write("Enter a lastName: ");
person1.LastName = System.Console.ReadLine();
System.Console.Write("Enter an age: ");
person1.Age = int.Parse(System.Console.ReadLine());
System.Console.WriteLine(person1.GetFullName());
System.Console.WriteLine($"My birth year is {person1.GetBirthAge()}");

