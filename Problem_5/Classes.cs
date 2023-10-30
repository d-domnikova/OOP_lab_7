class Citizens : ID {

    public string name;
    public int age;
    public string id { get; }

    public Citizens(string name, int age, string id)
    {
        this.name = name;
        this.age = age;
        this.id = id;
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

interface ID
{
    string id { get; } 
}