interface ID
{
    string id { get; }
}

interface Birthdate
{
    DateOnly birthdate { get; }
}

interface iBuyer
{
    int food { get; }
    int buyFood();
}