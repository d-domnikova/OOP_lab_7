class Ferarri : Car {
    string model;

    string driverName { get; set; }


    public Ferarri(string driverName)
    {
        this.model = "488-Spider";
        this.driverName = driverName;
    }

    public string useBrakes()
    {
        return "Brakes!";
    }
    public string pushTheGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{model}/{useBrakes()}/{pushTheGas()}/{driverName}";
    }
}


interface Car
{
    string useBrakes();
    string pushTheGas();
}