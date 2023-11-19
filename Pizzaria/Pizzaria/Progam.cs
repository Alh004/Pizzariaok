// See https://aka.ms/new-console-template for more information

using Pizzaria;

Console.WriteLine("Velkommen til Pizzariet");

Console.WriteLine("Vi har følgende pizzaer");


//Tilføjelse af pizzaer til menukort
Pizza pizza1 = new Pizza("Glutenfri", "Tun", 65, "Lille");

PizzaListe pizzaListe = new PizzaListe();
pizzaListe.Tilføj(pizza1);

Pizza pizza2 = new Pizza("Fuldkorn", "Kylling", 55, "Stor");
pizzaListe.Tilføj(pizza2);

Pizza pizza3 = new Pizza("Hvedmel", "Vegetar", 75, "Mellem");
pizzaListe.Tilføj(pizza3);




//Opret Kunde
Kunde kunde1=new Kunde(10,"Ali","42659793");
//Console.WriteLine(kunde1);

Kunde kunde2 = new Kunde(20,"Haris", "42658356");
//Console.Writeline(kunde2);

Kunde kunde3 = new Kunde(30,"Amin", "65239845");
//Console.WriteLine(kunde3);



//Opret Køb
Køb køb1=new Køb(pizza1, kunde1);
//Console.WriteLine(køb1);

Køb køb2 = new(pizza2, kunde2);
//Console.WriteLine(køb2);

Køb køb3 = new(pizza3, kunde3);
//Console.WriteLine(køb3);



//Udskrivelse af alle pizzaer
List<Pizza> pizzas = pizzaListe.HentAllePizzas();

for (int i = 0; i < pizzas.Count; i++)
{
    Console.WriteLine(pizzas[i]);
}



//søge efter pizzaer ud fra topping
Console.WriteLine("Med Tun");

List<Pizza> pizzaMedTun = pizzaListe.HentFraTopping("Tun");

//for (int i = 0; i < pizzaMedTun.Count; i++)
//{
//    Console.WriteLine(pizzaMedTun[i]);
//}
foreach (Pizza pizza in pizzaMedTun)
{
    Console.WriteLine(pizza);
}

// Slet en pizza
Console.WriteLine("\nSlet pizza med id 2:");
Pizza slettetPizza = pizzaListe.Slet(pizza1);
if (slettetPizza != null)
{
    Console.WriteLine($"Slettet pizza: {slettetPizza}");
}
else
{
    Console.WriteLine("Fejl: Pizza ikke slettet. pizza findes ikke.");
}



/*
 * BRUG AF KUNDE KATALOG
 */

KundeKatalog katalog = new KundeKatalog();


//Tilføjelse af Kunde
katalog.Tilføj(kunde1);
katalog.Tilføj(new Kunde(22, "Adam", "42556677"));




// Slet kunde
katalog.Slet(20); // Slet kunden med NUMMER 20




// Opdater kunde
Kunde opdateretKunde = new Kunde(10, "Opdateret Navn", "87654321");


Kunde opdateretKundeResultat = katalog.Opdater(opdateretKunde.kundenummer, opdateretKunde.Navn, opdateretKunde.Tlf);


if (opdateretKundeResultat != null)
{
    Console.WriteLine($"Kunde opdateret: {opdateretKundeResultat}");
}
else
{
    Console.WriteLine("FEJL: Kunde ikke opdateres. Kundenummeret findes ikke.");
}



// udskrivelse af kundekataloget
Console.WriteLine(katalog);

try
{
    Kunde kunde22 = katalog.HentKunde(22);
    Console.WriteLine(kunde22);
}
catch (KeyNotFoundException knfe)
{
    Console.WriteLine("FEJL: " + knfe.Message);
}


try
{ //    exception
    Console.WriteLine(katalog.HentKunde(222));

}
catch(KeyNotFoundException knfe)
{
    Console.WriteLine("FEJL: " + knfe.Message);
}
catch(Exception e)

//Finde kunde ud fra telefonnummer

{
    //Console.WriteLine(e.Message);
}

Console.WriteLine(katalog.HentKundeUdFraTlf("42659793"));









