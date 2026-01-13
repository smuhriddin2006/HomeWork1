namespace Task1;

public class Person
{
    public string FirsName {get; set;}=string.Empty;
    public string LastName {get; set;}=string.Empty;
    public int Age {get; set;}
    public string Address {get; set;}=string.Empty;

    public string GetFullName()
    {
        return $"My name is {FirsName} {LastName}";
    }

    public int GetBirthAge()
    {
      return 2026 - Age;
    }

}
