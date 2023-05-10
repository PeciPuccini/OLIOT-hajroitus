
(string, string, string) annos;

annos.Item1 = "";
annos.Item2 = "";
annos.Item3 = "";

bool loop = false;

string input;

while (annos.Item1 == "" || annos.Item2 == "" || annos.Item3 == "")
{
    //pääraaka-aine assign
    Console.WriteLine("Pääraaka-aine (" + Pääraakaaine.nautaa + ", " + Pääraakaaine.kanaa + ", " + Pääraakaaine.kasviksia + "):");
    input = Console.ReadLine();
    loop = true;
    while (loop)
    {
        if (input == "nautaa" || input == "kanaa" || input == "kasviksia")
        {
            annos.Item1 = input;
            loop = false;
        }
        else
        {
            input = Console.ReadLine();
        }
    }



    //lisuke assign
    Console.WriteLine("Lisuke (" + Lisuke.perunaa + ", " + Lisuke.riisiä + ", " + Lisuke.pastaa + "):");
    input = Console.ReadLine();
    loop = true;
    while (loop)
    {
        if (input == "perunaa" || input == "riisiä" || input == "pastaa")
        {
            annos.Item2 = input;
            loop = false;
        }
        else
        {
            input = Console.ReadLine();
        }
    }

    //kastike assign
    Console.WriteLine("Kastike (" + Kastike.pippuri + ", " + Kastike.chili + ", " + Kastike.tomaatti + ", " + Kastike.curry + "):");
    input = Console.ReadLine();
    loop = true;
    while (loop)
    {
        if (input == "pippuri" || input == "chili" || input == "tomaatti" || input == "curry")
        {
            annos.Item3 = input;
            loop = false;
        }
        else
        {
            input = Console.ReadLine();
        }
    }

    Console.WriteLine("Annoksesi: " + annos.Item1 + " ja " + annos.Item2 + " " + annos.Item3 + "-kastikkeella");

    Console.WriteLine("__________________________________________");

    Console.WriteLine("-Paina enter aloittaaksesi alusta-");
    input = Console.ReadLine();
    while (input != "")
    {
        Console.WriteLine("-Paina enter aloittaaksesi alusta-");
        input = Console.ReadLine();
    }

    Console.Clear();
    annos.Item1 = "";
    annos.Item2 = "";
    annos.Item3 = "";
}

enum Pääraakaaine {nautaa, kanaa, kasviksia}

enum Lisuke {perunaa, riisiä, pastaa}

enum Kastike {pippuri, chili, tomaatti, curry}