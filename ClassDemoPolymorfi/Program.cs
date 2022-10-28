// See https://aka.ms/new-console-template for more information
using ClassDemoPolymorfi.model;

Console.WriteLine("Hello, World!");


List<Animal> animals = new List<Animal>();
animals.Add(new Skade("Male", "Kugle rede i høje træer"));
animals.Add(new Skade("Female", "Kugle rede i høje træer"));
animals.Add(new Kat("Male", "Garfield", 15));
animals.Add(new Kat("Female", "Trøffel", 4));
animals.Add(new Guppy("Female", "orange"));
animals.Add(new Guppy("Female", "orange/rød"));
animals.Add(new Guppy("Male", "sølv/gul")); 
animals.Add(new Guppy("Male", "sølv/rød"));

foreach( Animal a in animals)
{
    Console.WriteLine(a);
}

Kat kat = new Kat("male", "Pussy", 4);
Console.WriteLine("min kat spiser : " + kat.Spiser() + "drikker " + kat.Drikker());


Animal nyKat = new Kat("???", "unknown", 5);
Console.WriteLine("min kat spiser : " + nyKat.Spiser() + "drikker " + nyKat.Drikker());

Kat NyKatKat = (Kat)nyKat;
Console.WriteLine("min kat spiser : " + NyKatKat.Spiser() + "drikker " + NyKatKat.Drikker());


//Animal animal = new Animal(AnimalKindType.Fugl, "male"); // kan ikke hvis Animal er abstrakt
//Console.WriteLine(animal);


