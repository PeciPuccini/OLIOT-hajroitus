bool loop = true;
bool tinyLoop = false;
string input;

Kärki kärki = Kärki.puu;
Perä perä = Perä.lehti;
int pituus = 0;

while (loop)
{
    loop = false;

    Console.WriteLine("--Nuoli Rakennus Generaattori--");

    //Kärki
    Console.WriteLine(".");
    Console.WriteLine("Millainen kärki? (puu, teräs, timantti):");
    input = Console.ReadLine();

    tinyLoop = true;
    while (tinyLoop)
    {
        if (input == "puu" || input == "teräs" || input == "timantti")
        {
            tinyLoop = false;

            if (input == "puu")
            {
                kärki = Kärki.puu;
            }
            else if (input == "teräs")
            {
                kärki = Kärki.teräs;
            }
            else if (input == "timantti")
            {
                kärki = Kärki.timantti;
            }
        }
        else
        {
            Console.WriteLine(".");
            Console.WriteLine("Millainen kärki? (puu, teräs, timantti):");
            input = Console.ReadLine();
        }
    }


    //Perä
    Console.WriteLine(".");
    Console.WriteLine("Millainen perä? (lehti, kanansulka, kotkansulka):");
    input = Console.ReadLine();

    tinyLoop = true;
    while (tinyLoop)
    {
        if (input == "lehti" || input == "kanansulka" || input == "kotkansulka")
        {
            tinyLoop = false;

            if (input == "lehti")
            {
                perä = Perä.lehti;
            }
            else if (input == "kanansulka")
            {
                perä = Perä.kanansulka;
            }
            else if (input == "kotkansulka")
            {
                perä = Perä.kotkansulka;
            }
        }
        else
        {
            Console.WriteLine(".");
            Console.WriteLine("Millainen perä? (lehti, kanansulka, kotkansulka):");
            input = Console.ReadLine();
        }
    }

    //Pituus
    Console.WriteLine(".");
    Console.WriteLine("Kuinka pitkä? (cm):");
    input = Console.ReadLine();

    tinyLoop = true;
    while (tinyLoop)
    {
        if ((Int32.Parse(input) >= 60 && Int32.Parse(input) <= 100))
        {
            tinyLoop = false;
            pituus = Int32.Parse(input);
        }
        else
        {
            Console.WriteLine(".");
            Console.WriteLine("Kuinka pitkä? (cm):");
            input = Console.ReadLine();
        }
    }

    //Lopputulos
    Console.WriteLine(".");
    nuoli uusinuoli = new nuoli(kärki, perä, pituus);

    Console.WriteLine("Hinta = " + uusinuoli.PalautaHinta() +" kultaa.");
}

class nuoli
{
    public Kärki kärki;
    public Perä perä;
    public int pituus;
    public double hinta;

    public nuoli(Kärki kärki, Perä perä, int pituus)
    {
        this.kärki = kärki;
        this.perä = perä;
        this.pituus = pituus;
    }

    public double PalautaHinta()
    {
        if (kärki == Kärki.puu)
        {
            hinta += 3;
        }
        else if (kärki == Kärki.teräs)
        {
            hinta += 5;
        }
        else if (kärki == Kärki.timantti)
        {
            hinta += 50;
        }

        if (perä == Perä.lehti)
        {
            hinta += 0;
        }
        else if (perä == Perä.kanansulka)
        {
            hinta += 1;
        }
        if (perä == Perä.kotkansulka)
        {
            hinta += 5;
        }

        hinta += pituus * 0.05;

        return hinta;
    }
}

enum Kärki { puu, teräs, timantti}

enum Perä { lehti, kanansulka, kotkansulka}