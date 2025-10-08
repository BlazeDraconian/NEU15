
var publisher = new Publisher();
var Subscriber1 = new Subscriber("Adam");
var Subscriber2 = new Subscriber("Eva");
var Subscriber3 = new Subscriber("Jonas");

publisher.Message += Subscriber1.OnMessageRecieved;
publisher.Message += Subscriber2.OnMessageRecieved;
publisher.Message += Subscriber3.OnMessageRecieved;

publisher.SendMessage("");
Console.WriteLine();
publisher.Message-= Subscriber3.OnMessageRecieved;
publisher.SendMessage("");




class MessageEventArgs : EventArgs
{
    public MessageEventArgs(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}

class Publisher
{
    public delegate void MessageEvent(object sender, EventArgs args);

    public event EventHandler <MessageEventArgs> Message;


    public void SendMessage(string message)
    {
        Message?.Invoke(this, new MessageEventArgs(message));
    }
}

class Subscriber
{
    private string name;

    public Subscriber(string name)
    {
        this.name = name;
    }

    public void OnMessageRecieved(Object sender, EventArgs args)
    {
        Console.WriteLine($"{name} got a message");
    }
}