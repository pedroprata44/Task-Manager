using Console;

namespace Tests;

public class UnitTest1: IDisposable
{
    public UnitTest1(){
    }
    public void Dispose(){
        System.Console.WriteLine("Hello");
    }

    [Fact]
    public void Test1()
    {
        Manager manager = new Manager();
        var inputTask = new {description = "task"};
        Console.Task task = manager.AddTask(inputTask.description);
        Assert.Equal(inputTask.description, task.Description);
    }
}