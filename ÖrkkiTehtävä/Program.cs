using System;

namespace orkki
{
    class Program
    {


        static void Main(string[] args)
        {
            int ritariHP = 15;
            int orkkiHP = 15;
            bool gameOn = true;
            int damage = 0;

            Random random = new Random();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Olet urhea ritari ja sinut on lähetetty murhaamaan kylää kiusaava örkki.");
            Console.WriteLine("Löydät örkin metsästä ja tämä hyökkää sinua kohti. Taistelu alkakoon!.");

            while (gameOn)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("---------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ritari(sinä): "+ ritariHP +"/15 Örkki: "+ orkkiHP +"/15");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 - Hyökkää miekalla");
                Console.WriteLine("2 - Puolustaudu kivellä");
                Console.WriteLine("Mitä haluat tehdä?:");
                int input = Int32.Parse(Console.ReadLine());
                if (input == 1)
                {
                    GenerateRandom(1, 7);
                    orkkiHP -= damage;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Hyökkäät miekallasi!");
                    Console.WriteLine("Puukotat örkkiä miekallasi. Teet örkkiin "+ damage +" vahinkoa!");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (orkkiHP < 1)
                    {
                        gameOn = false;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Onneksi olkoon! Olet nyt virallisesti murhaaja!");
                        break;
                    }

                    GenerateRandom(1, 7);
                    ritariHP -= damage;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Örkki hakkaa sinua nuijalla!");
                    Console.WriteLine("Nuija osuu päähäsi, tehden "+ damage +" vahinkoa.");

                    if (ritariHP < 1)
                    {
                        gameOn = false;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Örkki kuoletti sut. oot nyt kuollut. huono homma, eikös?");

                        break;
                    }
                }
                else if (input == 2)
                {
                    GenerateRandom(1, 7);
                    ritariHP -= damage;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nostat kivesi puolustukseksi!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Örkki hakkaa sinua nuijalla!");
                    Console.WriteLine("Nuija osuu kiveesi, tehden sinuun vain "+ damage +" vahinkoa.");
                    Console.ForegroundColor = ConsoleColor.White;

                    if (ritariHP < 1)
                    {
                        gameOn = false;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("---------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Örkki kuoletti sut. oot nyt kuollut. huono homma, eikös?");
                        break;
                    }
                }
                else if (input != 1 && input != 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("MIKSI SÄ KIRJOTAT JOTAIN MUUTA KUN 1 TAI 2?!! ET SAA ENÄÄ PELATA KUN YRITÄT GRIEFFATA TOLLEEN! >:O");
                    Environment.Exit(0);
                }

            }

            int GenerateRandom(int a, int b)
            {
                damage = random.Next(a, b);
                return damage;
            }
        }
    }
}