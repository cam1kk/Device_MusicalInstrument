class MusicalInstrument
{
    protected string name;
    public MusicalInstrument(string name)
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

    public virtual void History()
    {
        Console.WriteLine($"History: This is the history of {name}");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Violin: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Violin: High-pitched string instrument played with a bow.");
    }

    public override void History()
    {
        Console.WriteLine("History: Originating in the 16th century, the violin's expressive sound has made it a staple in classical and folk music worldwide.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Trombone: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Trombone: Brass wind instrument with a sliding tube for changing pitch.");
    }

    public override void History()
    {
        Console.WriteLine("History: Evolving since the Renaissance, the trombone's sliding tube enables versatile pitch control, enriching orchestral and brass ensemble performances.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Ukulele: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Ukulele: Small string instrument with four strings, associated with Hawaii.");
    }

    public override void History()
    {
        Console.WriteLine("History: Introduced to Hawaii in the late 19th century, the ukulele's cheerful tones have become synonymous with island culture and contemporary pop music.");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine($"\"{name} sounds\"");
    }

    public override void Show()
    {
        Console.WriteLine($"Cello: {name}");
    }

    public override void Desc()
    {
        Console.WriteLine("Cello: Large string instrument played between the legs with a bow.");
    }

    public override void History()
    {
        Console.WriteLine("History: With roots in the Baroque era, the cello's soulful resonance has earned it a prominent role in orchestras and solo performances across genres.");
    }
}
