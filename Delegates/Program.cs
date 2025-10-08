
var myDelegate = new MyDelegate(CountWords);

Func<string, int> Delegate= CountWords;

Console.WriteLine(myDelegate.Invoke("Hello World"));

myDelegate= CountChars;

Console.WriteLine(myDelegate("Hello World"));

myDelegate = null;

Console.WriteLine(myDelegate?.Invoke("Hello World"));

if (myDelegate is not null)
{
    Console.WriteLine(myDelegate.Invoke("Hello World"));
}

var strings = new string[] { "Hello World", "Good morning", "Hey" };

ProcessArray(strings, CountChars);
static void ProcessArray(string[] strings, MyDelegate myDelegate)
{   foreach (var item in strings)
    {
        Console.WriteLine(myDelegate(item));
    }
    
}

static int CountChars(string text)
{
    return text.Length;
}

static int CountWords(string text)
{
    return text.Split(' ').Length;
}

MyOtherDelegate functionDelegate = FunctionA;
functionDelegate += FunctionB;
functionDelegate += FunctionC;
functionDelegate.Invoke("Hello");

static void FunctionA(string text)
{
    Console.WriteLine($"FunctionA{text}");
}

static void FunctionB(string text)
{
    Console.WriteLine($"FunctionB{text}");
}

static void FunctionC(string text)
{
    Console.WriteLine($"FunctionC{text}");
}


public delegate int MyDelegate(string s);// Delegate

//Multicast delegate
public delegate void MyOtherDelegate(string s);

public delegate int MyGenericDelegate<T, TResult>(T x);

//Kommer för det mesta inte behöva använda dessa. Rekomenderat att använda Func istället

//Använd generiska delegat (Func (returvärde), Action ( inget returvärde) 
//Func< in T1, in T2,... out Tresult>
//Action<in T1, In T2, ...>



