class Smartphone : ICall, IBrowse
{
 public string calling(string number)
    {
        if (number.All(char.IsDigit))
        {
            return $"Calling... {number}";
        }
        else 
        {
            return "Invalid number.";
        }
    }

    public string browsing(string website)
    {
        if (!website.Any(char.IsDigit))
        {
            return $"Browsing: {website}";
        }
        else
        {
            return "Invalid URL.";
        }
    }
}

interface ICall
{
    string calling(string number);
}

interface IBrowse
{
    string browsing(string website);
}