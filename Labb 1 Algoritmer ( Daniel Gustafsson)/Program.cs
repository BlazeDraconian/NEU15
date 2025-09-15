
Console.WriteLine("Hejsan, var god skriv in ett antal heltal");
string UInput = Console.ReadLine(); //Sparar användarens input som en sträng
long AddedNumbers = 0;  // Skapar en variabel för talen som ska adderas ihop (Long, eftersom en int inte klarade av att spara stora antal)
for (int i = 0; i < UInput.Length; i++) //Loopar igenom hela strängen
{

    if (char.IsDigit(UInput[i])) //Kollar om varje char är en siffra 
    {
        char StartingNumber = UInput[i]; //Sparar det första tecknet
        for (int j = i + 1; j < UInput.Length; j++) //Inre loop som körs efter det första tecknet 
        {


            if (UInput[j] == StartingNumber) // Om tecknet matchar den första siffran 
            {
                int längd = j - i - 1; //Extra längdvariabel då programmet krashar om värdet blir 0
                if (längd > 0)
                {


                    string MellanTal = UInput.Substring(i + 1, längd); // Sparar alla tal som förekommer mellan första och sista siffran 
                    bool isbetween = true; //Skapar en bool som ska hålla reda på om tecknet är mellan det första och sista
                    for (int k = 0; k < MellanTal.Length; k++) //Inre loop som avgör ifall talen förekommer mellan första och sista siffran
                    {
                        if (!char.IsDigit(MellanTal[k]) || MellanTal[k] == StartingNumber) //Inre loop som är falsk ifall tecknen inte ligger mellan första och sista talet
                        {
                            isbetween = false;
                            break; // Avslutar loopen
                        }

                    }
                    if (isbetween) //Om boolen är sann 
                    {
                        string Between = UInput.Substring(i, j - i + 1); //Sparar siffrorna som matchar kriterierna 

                        Console.Write(UInput.Substring(0, i)); // Skriver ut den första siffran 
                        Console.ForegroundColor = ConsoleColor.Magenta; // Ändrar färgen på tecknen till lila
                        Console.Write(Between); // Skriver ut alla siffror mellan start och slut som matchar kriterierna 
                        Console.ResetColor(); // Ändrar tillbaka färgen till vit
                        Console.WriteLine(UInput.Substring(j + 1)); // Skriver ut resten av raden 
                        AddedNumbers += long.Parse(Between); // Adderar ihop alla talen som matchar 

                    }
                }
            }

        }
       
    }
}   Console.WriteLine(); // Radbyte för att skapa mellanrum
    Console.WriteLine($"Sammanlagt blir talen {AddedNumbers}"); // Skriver ut det adderade antalet
