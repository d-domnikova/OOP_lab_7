class Citizens : ID, Birthdate, iBuyer
{
    public string name {  get; }
    int age;
    public string id { get; }
    public DateOnly birthdate { get; }
    public int food { get; set; }

    public Citizens(string name, int age, string id, DateOnly birthdate)
    {
        this.name = name;
        this.age = age;
        this.id = id;
        this.birthdate = birthdate;
        food = 0;
    }

    public int buyFood()
    {
        return food += 10;
    }

}

class Rebel : iBuyer
{
    public string name { get; }
    int age;
    string group;
    public int food { get; set; }

    public Rebel(string name, int age, string group)
    {
        this.name = name;
        this.age = age;
        this.group = group;
        food = 0;
    }

    public int buyFood()
    {
        return food += 5;
    }
}