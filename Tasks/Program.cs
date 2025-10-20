
//Task myTask = Task.Run(TaskOne);
Task myTask = new Task(TaskOne);

Console.WriteLine($"MyTask status is : {myTask.Status}"); 

myTask.Start();

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"Main process:{i}");
}

Console.WriteLine($"MyTask status is : {myTask.Status}");
Console.WriteLine("The end");
static void TaskOne()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"Task 1: {i}");
    }
    Console.WriteLine("Running task 1");
}
