var house1 = new House()
{
  
};


class House
{
    public readonly string Address = "Street";

    public House()
    {
        if (Address.Length >= 5)
        {
            return;
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    public override string ToString()
    {
        if (house1.name ==! null)
        {
            Console.WriteLine("${house.name}");
        }
        else
        {
            Console.WriteLine("${Address}");
        }
    }
};