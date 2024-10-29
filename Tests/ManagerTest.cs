using Console;

namespace Tests;

public class ManagerTest{
    private readonly Manager manager;
    public ManagerTest(){
        manager = new ();
    }
    [Fact]
    public void ShouldAddTaskToTaskList()
    {
        // Given
        var inputTask = new {
            description = "task"
        };
        // When
        Console.Task task = manager.AddTask(inputTask.description);
        // Then
        Assert.Equal(inputTask.description, task.Description);
    }
}