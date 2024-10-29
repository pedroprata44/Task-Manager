using Console;

namespace Tests;

public class UnitTest1: IDisposable
{
    Manager manager;
    public UnitTest1(){
        manager = new ();
    }
    public void Dispose(){
        System.Console.WriteLine("Hello");
    }

    [Fact]
    public void Test1()
    {
        var inputTask = new {description = "task"};
        Console.Task task = manager.AddTask(inputTask.description);
        Assert.Equal(inputTask.description, task.Description);
    }
}