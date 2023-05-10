string task;
kaappi kaapinovi;
kaapinovi = kaappi.EnsimmäinenTila;
while (true)
{
    Console.WriteLine("Mitä tehdään? ");
    Console.WriteLine("1 - Avaa kaappi");
    Console.WriteLine("2 - Sulje kaappi");
    Console.WriteLine("3 - Lukitse kaappi");
    Console.WriteLine("4 - Avaa kaapin lukko");

    task = Console.ReadLine();

    if (kaapinovi == kaappi.EnsimmäinenTila)
    {
        if (task == "1")
        {
            Console.WriteLine("Ovi on nyt auki");
            kaapinovi = kaappi.Auki;
        }
        if (task == "2")
        {
            Console.WriteLine("Ovi on nyt kiinni");
            kaapinovi = kaappi.Kiinni;
        }
        if (task == "3")
        {
            Console.WriteLine("Ovi on nyt lukossa");
            kaapinovi = kaappi.Lukossa;
        }
        if (task == "4")
        {
            Console.WriteLine("Ovi on nyt kiinni");
            kaapinovi = kaappi.Kiinni;
        }
    }

    if (task == "1" && kaapinovi == kaappi.Kiinni)
    {
        Console.WriteLine("Ovi on nyt auki");
        kaapinovi = kaappi.Auki;
    }
    if (task == "2" && kaapinovi == kaappi.Auki)
    {
        Console.WriteLine("Ovi on nyt kiinni");
        kaapinovi = kaappi.Kiinni;
    }
    if (task == "3" && kaapinovi == kaappi.Kiinni)
    {
        Console.WriteLine("Ovi on nyt lukossa");
        kaapinovi = kaappi.Lukossa;
    }
    if (task == "4" && kaapinovi == kaappi.Lukossa)
    {
        Console.WriteLine("Ovi ei ole enään lukossa");
        kaapinovi = kaappi.Kiinni;
    }
    Console.WriteLine("________________");
}

enum kaappi { Auki, Kiinni, Lukossa, EnsimmäinenTila };