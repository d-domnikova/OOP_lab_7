class Mission : IMission
{
    public string codeName {  get; }
    public bool state {  get; set; }
    public Mission(string codeName, bool state)
    {
        this.codeName = codeName;
        this.state = true;
    }

    public bool completeMission()
    {
        if (state) { state = false; }
        return state;
    }
    
    public override string? ToString()
    {
        return $"Code Name: {codeName} State: {(state ? "inProgress" : "Finished" )}";
    }
}

class Repair : IRepair
{
    public string partName { get; }
    public int hoursWorked { get; }

    public Repair(string partName, int hoursWorked)
    {
        this.partName = partName;
        this.hoursWorked = hoursWorked;
    }

    public override string? ToString()
    {
        return $"Part Name: {partName} Hours Worked: {hoursWorked}";
    }
}