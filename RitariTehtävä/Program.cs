using System;
Console.Title = "Ritariryhmä liikkeelle";
Console.WriteLine("Kohde rivi?:");
int rivi2 = System.Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Kohde sarake?:");
int sarake2 = System.Convert.ToInt32(System.Console.ReadLine());
Console.WriteLine("Lähetetään ritarit.");

int rivi1 = rivi2 - 1;
int rivi3 = rivi2 + 1;

int sarake1 = sarake2 - 1;
int sarake3 = sarake2 + 1;

Console.Beep();
Console.WriteLine("Ritari 1 kohteeseen (" + rivi2 + ", " + sarake1 + ")");
Console.WriteLine("Ritari 1 kohteeseen (" + rivi1 + ", " + sarake2 + ")");
Console.WriteLine("Ritari 1 kohteeseen (" + rivi2 + ", " + sarake3 + ")");
Console.WriteLine("Ritari 1 kohteeseen (" + rivi3 + ", " + sarake2 + ")");