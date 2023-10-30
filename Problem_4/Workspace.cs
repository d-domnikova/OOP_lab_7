class Workspace
{
    static void Main(string[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        string[] websites = Console.ReadLine().Split(' ');
        Smartphone smartphone = new Smartphone();

        foreach (string number in numbers)
        {
            Console.WriteLine(smartphone.calling(number));
        }

        foreach (string site in websites)
        {
            Console.WriteLine(smartphone.browsing(site));
        }
    }
}