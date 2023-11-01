class Soldier : ISoldier
{
    public string firstName { get; }
    public string lastName { get; }
    public int id { get; }

    public Soldier(string firstName, string lastName, int id)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = id;
    }

    public override string ToString()
    {
        return $"Name: {firstName} {lastName} Id: {id}";
    }
}

class Spy : Soldier, ISpy
{
    public int codeNumber { get; }

    public Spy(string firstName, string lastName, int id, int codeNumber) : base(firstName, lastName, id)
    {
        this.codeNumber = codeNumber;
    }

    public override string ToString()
    {
        return $"{base.ToString()} \nCode Number: {codeNumber}";
    }
}

class Privates : Soldier, IPrivate
{
    public double salary { get; }
    public Privates(string firstName, string lastName, int id, double salary) : base(firstName, lastName, id)
    {
        this.salary = salary;
    }
    public override string ToString()
    {
        return $"{base.ToString()} Salary: {salary.ToString("F")}";
    }
}
