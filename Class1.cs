public class class1
{
    public string location { get; set; }
    public DateTime date { get; set; }
    public string phone { get; set; }
    public string details { get; set; }
}

public class MoneyItem : class1
{
    public override string ToString()
    {
        return "Location: " + location + " - Details: " + details;
    }
}