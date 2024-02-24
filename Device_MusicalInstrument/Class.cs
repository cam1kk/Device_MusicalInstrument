class Device
{
    protected string name;

    public Device(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{name} makes a sound");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Device: {name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Description: This is a {name}");
    }
}

class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Kettle: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Kettle: Household device for boiling water.");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }
    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Microwave: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Microwave: Device for quick food preparation.");
    }
}

class Car : Device
{
    public Car(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Car: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Car: Vehicle for transportation.");
    }
}

class Steamboat : Device
{
    public Steamboat(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Steamboat: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Steamboat: Vessel for water transportation powered by steam.");
    }
}