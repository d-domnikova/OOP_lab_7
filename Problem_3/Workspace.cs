class Workspace
{
    static void Main(string[] args)
    {
        string driversName = Console.ReadLine();
        Ferarri ferarri = new Ferarri(driversName);
        Console.WriteLine(ferarri);
    }
}