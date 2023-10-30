interface IPerson
{
    abstract string Name { get; set; }
    abstract int Age { get; set; }
}

interface IIdentifiable
{
    abstract string Id { get; set; }
}

interface IBirthday
{
    abstract string BirthDate {  get; set; }
}

class Citizen : IPerson, IIdentifiable, IBirthday
{
    private string name;
    public string Name { get { return name; } set { name = value; } }

    private int age;
    public int Age { get { return age; } set { age = value; } }

    private string id;
    public string Id { get { return id; } set { id = value; } }

    private string birthDate;
    public string BirthDate { get { return birthDate; } set { birthDate = value; } }

    public Citizen(string name, int age, string id, string birthdayDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.BirthDate = birthdayDate;
    }
}