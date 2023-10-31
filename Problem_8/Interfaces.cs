interface ISoldier
{
    public string firstName { get; }
    public string lastName { get; }
    public int id { get; }
    public string ToString();
}

interface IPrivate
{
    public double salary { get; }
    public string ToString();
}

interface ILeutenantGeneral
{
    public List<Privates> privates { get; }
    public string ToString();
}

interface ISpecialSoldier
{
    public string corps {  get; }
    public string ToString();
}

interface IEngineer
{
    public List<Repair> repairs { get; }
    public string ToString();
}

interface ICommando
{
    public List<Mission> missions { get; }
    public string ToString();
}

interface ISpy
{
    public int codeNumber { get; }
    public string ToString();
}


interface IRepair
{
    public string partName { get; }
    public int hoursWorked {  get; }
    public string ToString();
}

interface IMission
{
    public string codeName { get; }
    public bool state {get;}
    public bool completeMission();
    public string ToString();
}
