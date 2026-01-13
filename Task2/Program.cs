using System.Drawing;

using Task2;
Recttangle recttangle = new Recttangle();
System.Console.Write("width: ");
recttangle.Width = double.Parse(System.Console.ReadLine());
System.Console.Write("height: ");
recttangle.Height = double.Parse(System.Console.ReadLine());
double res = recttangle.GetArea();
System.Console.WriteLine("Area = " + res);