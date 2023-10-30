using System;

class Workspace
{
    static void Main() 
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthday birthday = new Citizen(name, age, id, birthdate);

        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthday.BirthDate);
    }
}