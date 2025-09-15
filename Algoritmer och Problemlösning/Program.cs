
//Uppgift 1 : Utgå från strängen (skapa en variabel med) "Hello World!", skriv ut hela strängen bokstav för bokstav, men avsluta när det kommer ett space.
//(Den ska alltså bara skriva “Hello”).
/*
String hworld = "Hello World!";
foreach (char letters in hworld)
{
   Console.Write(letters);
    if (letters == ' ')
    {
        break;
    }
}
*/
//Uppgift 2 : Utgå från strängen "This is just some other text". Skriv ut strängen bokstav för bokstav, men när det kommer ett space, gör radbyte istället. 
//(Du ska få ett ord på varje rad)
/*
String samee = "This is just some other text";
foreach (char letterss in samee)
{
    Console.Write(letterss);
    if (letterss == ' ')
    {
        Console.WriteLine();
    }
}
*/

//Uppgift 3 :Utgå från strängen "Detta är uppgift 3". Skriv ut bokstav för bokstav. Men om index är en jämn siffra, skriv istället ut *

/*
String upgft3 = "Detta är uppgift 3";
for (int i = 0; i < upgft3.Length; i++) 
{
    char letters = upgft3[i];

    if (i % 2 == 0)
    {
        Console.Write(letters);
    }

    else
    {
        Console.Write("*");
    }
}
*/

//Uppgift 4 : Utgå från strängen "Hello world!". Skriv ut bokstav för bokstav. Alla 'o' ska vara grön färg, alla 'l' ska vara röd färg. Övriga bokstäver är vita/grå.
/*
String upgft4 = "Hello world!";
for (int i = 0; i < upgft4.Length; i++)
{
    char letters = upgft4[i];

    if (letters == 'o')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(letters);
    }

    else if (letters == 'l')
    {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.Write(letters);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(letters);

    }
}*/

//Uppgift 5 : Utgå från strängen "Hello world". Skriv ut bokstav för bokstav. Om två tecken på rad är samma så ska dessa vara grön färg. Övriga bokstäver är vita/grå.
/*
string hw = "Hello World !";
char previous = '\0';

foreach (char letters in hw)
{
    
    if (letters == previous)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(letters);
        Console.ResetColor();
        previous = letters;
    }
    else
    {
        
        Console.Write(letters);
        previous = letters;
    }
}
*/

//Uppgift 6 : Utgå från strängen "How much wood would a woodchuck chuck if a woodchuck chucks wood?", samt den mindre strängen "oo".
//Skriv ut den långa strängen bokstav för bokstav. Varje gång den mindre strängen förekommer (två 'o' på raken) så ska dessa vara med grön färg. Övriga bokstäver är vita/grå.
/*
String WoodChuck = "How much wood would a woodchuck chuck if a woodchuck chucks wood?";
string Oo = "oo";

for (int i = 0; i < WoodChuck[WoodChuck.Length - 1]; i++)
{
    string DoubleChuck = "" + WoodChuck[i] + WoodChuck[i + 1];

    if (DoubleChuck == Oo)
    {
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(WoodChuck[i]);
        Console.Write(WoodChuck[i + 1]);
        Console.ResetColor();
        i++;
    }
    else
    {

        Console.Write(WoodChuck[i]);
        
    }
}
*/

//Uppgift 7: Samma som uppgift 6, men den mindre strängen är "chuck" istället för "oo". D.v.s. alla gånger "chuck" förekommer i den längre strängen skrivs dessa med grön text.
/*
String WoodChuck = "How much wood would a woodchuck chuck if a woodchuck chucks wood?";
string Chuck = "chuck";

for (int i = 0; i < WoodChuck.Length; i++)

{
    string Ch = WoodChuck.Substring(i, Math.Min(Chuck.Length, WoodChuck.Length - i));
    if ( Ch == Chuck )
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Chuck);
        Console.ResetColor();
        i+= Chuck.Length - 1; 
    }
    else
    {

        Console.Write(WoodChuck[i]);

    }
}*/

//Uppgift 8: Samma som uppgift 6 igen, men denna gången kan användaren mata in den kortare strängen, alltså valfri text som ska sökas (färgas grön) i den längre texten.
/*
String WoodChuck = "How much wood would a woodchuck chuck if a woodchuck chucks wood?";
Console.WriteLine("Mata in en sträng som ska sökas i texten: ");
string Uinput = Console.ReadLine();

for (int i = 0; i < WoodChuck.Length; i++)
{
    string Ch = WoodChuck.Substring(i, Math.Min(Uinput.Length, WoodChuck.Length - i));

    if (Ch == Uinput)
    {

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(Uinput);
        Console.ResetColor();
        i+= Uinput.Length - 1;
    }
    else
    {

        Console.Write(WoodChuck[i]);

    }
}*/

//Uppgift 9 : Utgå från strängen "Hello world!". Gör ett program som skriver ut första bokstaven en gång på första raden. Andra bokstaven 2 gånger på andra raden. Tredje 3 gånger på nästa rad osv. Alltså:
/*H
ee
lll
... etc*/

String hello = "Hello world!";
for (int i = 0; i < hello.Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(hello[i]);
        
    }
    Console.WriteLine();
}
//Uppgift 10 : Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”.
//Gör ett program som skriver ut första ordet en gång på första raden; andra ordet två gånger på nästa rad. Tredje ordet tre gånger på nästa. etc. alltså:
/* How
much much
wood wood wood
... etc */
/*
String woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
string[] words = woodchuck.Split(' ');
for (int i = 0; i < words.Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(words[i] + " ");
    }
    Console.WriteLine();
}
*/

//Uppgift 11 : Utgå från strängen “How much wood would a woodchuck chuck if a woodchuck could chuck wood?”. Gör ett program som på första raden skriver ut första ordet.
//På nästa rad skriver ut de två första orden, sedan de tre första orden på nästa rad o.s.v till man kommit till raden som skriver ut hela meningen. Alltså:
/*  How
How much
How much wood
... etc*/
/*
String woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
for (int i = 0; i < woodchuck.Split(' ').Length; i++)
{
    for (int j = 0; j <= i; j++)
    {
        Console.Write(woodchuck.Split(' ')[j] + " ");
    }
    Console.WriteLine();
}
*/

//Uppgift 12: Utgå från samma sträng igen, men denna gång ska programmet skriva ut hela strängen på varje rad.
//På första raden ska första ordet vara rött (övriga vita), på andra raden ska andra ordet vara rött. På tredje raden ska tredje vara rött osv. Alltså:
/* How much wood would a woodchuck chuck if a woodchuck could chuck wood?
How much wood would a woodchuck chuck if a woodchuck could chuck wood? */
/*
String woodchuck = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?";
for (int i = 0; i < woodchuck.Split(' ').Length; i++)
{
    for (int j = 0; j < woodchuck.Split(' ').Length; j++)
    {
        if (j == i)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(woodchuck.Split(' ')[j] + " ");
            Console.ResetColor();
        }
        else
        {
            Console.Write(woodchuck.Split(' ')[j] + " ");
        }
    }
    Console.WriteLine();
}
*/


//Uppgift 13 : Utgå från strängen "abcdefghijklmnopqrstuvwxyz". Hela strängen skrivs ut på varje rad. På första raden är de 5 första tecknen röda.
//På nästa rad är “bcdef” röda, sedan “cedfg” osv.. alltså alltid 5 tecken, men de flyttas ett steg åt höger för varje rad, tills sista raden har “vwxyz” rödfärgad. Alltså:
/* abcdefghijklmnopqrstuvwxyz
abcdefghijklmnopqrstuvwxyz*/

/*
String Alphabet = "abcdefghijklmnopqrstuvwxyz";
for (int i = 0; i < Alphabet.Length - 5 + 1; i++)
{
    Console.Write(Alphabet.Substring(0 , i));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(Alphabet.Substring(i , 5));
    Console.ResetColor();
    Console.Write(Alphabet.Substring(i , 5));
    
}
Console.WriteLine();
*/

//Uppgift 14: Användaren matar in valfri sträng. Programmet skriver ut hela strängen bokstav för bokstav.
//Alla bokstäverna är röda fram tills du stöter på ett tecken som är samma som första tecknet i strängen.
//Därefter skriver den ut resten av bokstäverna med vit/grå färg. Några exempel vid olika inmatningar/körningar:
/* ajdfhvajhdfd
hhfgijff
fjpdpog */


/*
String uInput = Console.ReadLine();
bool isRed = true;
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(uInput[0]);
Console.ResetColor();

for (int i = 1; i < uInput.Length; i++)
 
{ if (isRed)
    {    
        if (uInput[i] == uInput[0])
        {
            isRed = false;
            Console.Write(uInput[i]);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(uInput[i]);
            Console.ResetColor();
        }
    } else
    {
        Console.Write(uInput[i]);
    }
} */


