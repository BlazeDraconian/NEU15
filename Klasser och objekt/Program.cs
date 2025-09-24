/*
Cat myCat = new Cat();
myCat.name = "Cosmo";
myCat.age = 11;
Console.WriteLine($"{myCat.name} är {myCat.age} år gammal");

Cat myCat2 = new Cat();
myCat2.name = "Archer";
myCat2.age = 12;
Console.WriteLine($"{myCat2.name} är {myCat2.age} år gammal");

Cat mySameCat = myCat;
Console.WriteLine(mySameCat.name);

Cat myCat4 = new Cat() { name = "Sparrow", age = 5 };
Console.WriteLine($"{myCat4.name} är {myCat4.age} år gammal");



//

Cat[] cats = new Cat[] {myCat, myCat2, myCat4};

foreach (var Cat in cats)
{
    Console.WriteLine(Cat.name);
}


myCat.Greet();
Console.WriteLine(Cat.numberOfLives);

class Cat
{
    public string name = "Default name";
    public int age = 0;
    public double weight = 0;
    public static int numberOfLives = 9; 

    public void Greet()
    {
        Console.WriteLine($"Hej jag heter {name} ");
    }

    private int GetDoubleAge()
    {
        return age * 2;
    }
}*/


//# Övningsuppgifter med klasser och objekt

//## 1. Skriva ut namn på personer using System: Skriv en klass som representerar en person. Klassen ska ha två publika fält (fields): firstName, lastName. 
//Skapa två instanser av personer med olika för och efternamn, och använd sedan dessa för att printa ut (hela) namnen på de olika personerna.
/*
name namn1 = new name() { firstName = "Dalanar", lastName = "Kholin" };
name namn2 = new name() { firstName = "Linus", lastName = "Mills" };

Console.WriteLine($"{namn1.firstName} {namn1.lastName}");
Console.WriteLine($"{namn2.firstName} {namn2.lastName}");

class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";

}

*/
//## 2. Lägg till en metod som returnerar hela namnet. Uppdatera klassen i uppgift 1 med en metod: public string GetFullName(), som returnerar en sträng med hela namnet.
/*name namn1 = new name() { firstName = "Dalanar", lastName = "Kholin" };
name namn2 = new name() { firstName = "Linus", lastName = "Mills" };

Console.WriteLine(namn1.GetFullName());

class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
  

      public string GetFullName()
    {
        return firstName + " " + lastName;
    }
}

*/

//## 3. Lägg till en metod som returnerar namnet baklänges. Uppdatera klassen med en ny metod: public string GetFullNameReversed() som returnerar en sträng med hela namnet baklänges. 
//Låt denna metoden använda sig av metoden i uppgift 2.
/*
name namn1 = new name() { firstName = "Dalanar", lastName = "Kholin" };
name namn2 = new name() { firstName = "Linus", lastName = "Mills" };

Console.WriteLine(namn1.GetFullNameReversed());

class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";


    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetFullNameReversed()
    {
        return lastName+ " " + firstName;
    }
}
*/


//## 4. Overload av GetFullName med titel.GetFullName ska finnas i två versioner: en utan parametrar som i uppgift 2; 
//och en där man kan skicka in en titel, t.ex. "Dr." eller "Mr." som returnerar namnet på personen med titeln framför.
/*
name namn1 = new name() { title = "Sir ",firstName = "Dalanar", lastName = "Kholin" };
name namn2 = new name() {title = "Inquisitor" ,firstName = "Linus", lastName = "Mills" };

Console.WriteLine(namn1.GetFullName("Sir"));


class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    public string title = "Default title";

    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

   public string GetFullName(string title)
    {
        return title + " " + firstName + " " + lastName;
    }
   
}
*/

//## 5. Lägg till så personer kan ha föräldrar.
//Uppdatera person-klassen så att varje person kan ha en mamma och en pappa. Dessa representeras som publika fält(fields) av typen Person (eller vad du kallade klassen i uppgift 1).
/*
name namn1 = new name() {pappa= "Kersidar", firstName = "Dalanar", lastName = "Kholin" };
name namn2 = new name() { firstName = "Linus", lastName = "Mills" };

Console.WriteLine(namn1.GetFullName("Sir"));
Console.WriteLine(namn1.mamma);
Console.WriteLine($"Pappans namn är { namn1.pappa}");


class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    public string title = "Default title";
    public string mamma = "Ingen mamma";
    public string pappa = "Ingen pappa";
    public string GetFullName()
    {
        return firstName + " " + lastName; 
    }

    public string GetFullName(string title)
    {
        return title + " " + firstName + " " + lastName;
    }

}
*/

//## 6. Skapa ett objekt som representerar dig och dina föräldrar
//Gör en instans av en person och ge den ditt för- och efternamn. Lägg även in dina föräldrars namn, kopplade till dig. 
//Så t.ex myself.GetFullName() returnerar ditt namn, och myself.mother.GetFullName() returnerar din mammas namn.   ( Because of privacy reasons i will not use mine or my parents names) 
/*
name namn1 = new name() {mamma= "My Mother's Name", pappa = "My Father's Name", firstName = "My Name", lastName = "My Last Name" };


Console.WriteLine($"Mitt namn är {namn1.GetFullName()}");
Console.WriteLine($"Mammas namn är {namn1.mamma}");
Console.WriteLine($"Pappas namn är {namn1.pappa}");


class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    public string title = "Default title";
    public string mamma = "Ingen mamma";
    public string pappa = "Ingen pappa";
    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetFullName(string title)
    {
        return title + " " + firstName + " " + lastName;
    }


}
*/


//## 7. Hämta information om dig och dina föräldrar. Lägg till en public string GetSelfAndParents() 
//som returnerar en sträng på formatet "Ditt Namn - Mamma: Mammans Namn - Pappa: Pappans namn". 
//Om mammans eller pappans namn saknas (null) markera det med "okänd" i strängen. Exempel: "Fredrik Johansson - Mamma: okänd - Pappa: Göran Johansson"
/*
name namn1 = new name() { mamma = "My Mother's Name", pappa = "My Father's Name", firstName = "My Name", lastName = "My Last Name" };


Console.WriteLine(namn1.GetSelfAndParents());



class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    public string title = "Default title";
    public string mamma = "Ingen mamma";
    public string pappa = "Ingen pappa";
    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public string GetSelfAndParents()
    {
        return firstName + " " + lastName + "     " + "Pappan heter " + pappa + "   " + "Mamman heter " + mamma ;
    }


}
*/
//## 8. Privat fält, med metoder för att sätta och hämta värdet. Uppdatera klassen med ett fält, *private* double length, som kan lagra längden på personen. 
//Eftersom denna är markerad som private kommer man inte kunna läsa/skriva denna utanför klassen. 
//Lägg därför till en metod void SetLength(double length) som sätter värdet på det privat fältet length, samt en double GetLength() som returnerar värdet på fältet length.
/*
name namn1 = new name() {firstName = "Dalanar", lastName = "Kholin" };
name namn2 = new name() { firstName = "Linus", lastName = "Mills" };

namn1.SetLenght(165.8);
Console.WriteLine(namn1.GetFullName());
Console.WriteLine(namn1.getLenght());

class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    private double lenght; 

    public void SetLenght(double length)
    {
        lenght = 165.8;
    }

    public double getLenght()
    {
        return lenght;
    }
    public string GetFullName()
    {
        return firstName + " " + lastName;
    }
}
*/


//## 9. Vikt och BMI. Gör motsvarande för Vikt, alltså ett privat fält med publika metoder: double GetWeight() och void SetWeight(double weight).
//Gör sedan även en publik metod double GetBMI() som returnerar personens [BMI] (https://sv.wikipedia.org/wiki/BMI_(kroppsmasseindex)). Detta ska dock *inte* finnas representerat som en private field.
/*
name namn1 = new name() { firstName = "Dalanar", lastName = "Kholin" };


namn1.SetLenght(165.8);
namn1.SetWeight(72.5);
Console.WriteLine(namn1.GetFullName());
Console.WriteLine(namn1.getLenght());
Console.WriteLine(namn1.getWeight());
Console.WriteLine ($"Deras BMI-värde är {namn1.GetBMI()}");
class name
{
    public string firstName = "Default name";
    public string lastName = "Default name";
    private double lenght;
    private double weight; 

    public void SetWeight(double weight)
    {
         this.weight = weight; 
    }
    public void SetLenght(double length)
    {
        this.lenght = length;
    }

    public double getWeight()
    {
        return weight;
    }
    public double getLenght()
    {
        return lenght;
    }
    public string GetFullName()
    {
        return firstName + " " + lastName;
    }

    public double GetBMI()
    {
        double meters = lenght / 100;
        return weight / (meters * meters);
    }
} 
*/