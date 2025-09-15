/*checked
{
    byte myByte = 200;
                      // Exempel på en System.Overflow Exception.
                      //Utan checked-blocket får vi ingen exception.
    myByte += 100;
    Console.WriteLine(myByte);
}
*/


/*
byte.Parse("hej"); // System.Format Exception. 'The input string 'hej' was not in a correct format'



int[] myArray = new int[10];
myArray[15] = 3;  //IndexOutOfRange Exception. ' Index was outside the bounds of the array'

*/

/*
int x =  0;  
int y = 1/x; // DivideByZero Exception ' attempted to divide by zero'
*/


// Exempel på ett Try/Catch/finaly block
/*
static void TryCatchexample()
{


    try
    {
        Console.WriteLine("Start of try block");
        byte.Parse("hej");
        int[] myArray = new int[10];
        myArray[15] = 3;
        Console.WriteLine("End of try block");
    }
    catch (IndexOutOfRangeException ex) //Catch kommer bara pånga upp den angivna typen av exception
    {
        Console.WriteLine("Array indexing went wrong");
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Parsing went wrong");
    }

    catch (Exception ex)
    {
        Console.WriteLine($"Something went wrong {ex.Message}");
        Console.WriteLine(ex.StackTrace);
    }
    finally
    {
        Console.WriteLine("This always runs at the end of the try/catch.");
    }
}



Console.WriteLine("Program start"); //Kallar på Try/catch blocken som en funktion  
try
{
    TryCatchexample();
}
catch
{
    Console.WriteLine("Error: something went wrong");
}
Console.WriteLine("The end ");
*/

static int OneDividedbyX(int x) // Funktion för att medvetet skriva ut en exception 
{ 
    if (x < 1 || x > 100)
    {
        throw new ArgumentOutOfRangeException();
    }
    return 1 / x; 
}





