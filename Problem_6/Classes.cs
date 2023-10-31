class Citizens : ID, Birthdate
{
    string name;
    int age;
    public string id { get; }
    public DateOnly birthdate { get; }

    public Citizens(string name, int age, string id, DateOnly birthdate)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.birthdate = birthdate;
    }
}

class Robot : ID
{
    public string model;
    public string id { get; }

    public Robot(string model, string id)
    {
        this.model = model;
        this.id = id;
    }
}

class Pet : Birthdate
{
    string name;
    public DateOnly birthdate { get; }

    public Pet(string name, DateOnly birthdate)
    {
        this.name = name;
        this.birthdate = birthdate;
    }
}