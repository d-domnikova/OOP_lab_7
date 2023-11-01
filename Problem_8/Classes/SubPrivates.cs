class LeutenantGenereal : Privates, ILeutenantGeneral
{
    public List<Privates> privates { get; set; }

    public LeutenantGenereal(string firstName, string lastName, int id, double salary, List<Privates> privates) : base(firstName, lastName, id, salary)
    {
        this.privates = privates;
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nPrivates: \n{string.Join("\n", privates)}";
    }
}

class SpeciaslSoldier : Privates, ISpecialSoldier
{
    public string corps { get; }

    public SpeciaslSoldier(string firstName, string lastName, int id, double salary, string corps) : base(firstName, lastName, id, salary)
    {
        this.corps = corps;
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nCorps: {corps}";
    }
}

class Engineer : SpeciaslSoldier, IEngineer
{
    public List<Repair> repairs { get; set; }

    public Engineer(string firstName, string lastName, int id, double salary, string corps, List<Repair> repairs) : base(firstName, lastName, id, salary, corps)
    {
        this.repairs = repairs;
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nRepairs: \n{string.Join("\n", repairs)}";
    }
}

class Commando : SpeciaslSoldier, ICommando
{
    public List<Mission> missions { get; set; }

    public Commando(string firstName, string lastName, int id, double salary, string corps, List<Mission> missions) : base(firstName, lastName, id, salary, corps)
    {
        this.missions = missions;
    }
    public override string ToString()
    {
        return $"{base.ToString()} \nMissions: \n{string.Join("\n", missions)}";
    }
}