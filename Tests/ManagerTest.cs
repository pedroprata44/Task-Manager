using Console;

namespace Tests;

public class ManagerTest{
    private readonly Manager manager;
    public ManagerTest(){
        manager = new ();
    }
    [Fact]
    public void ShouldAddTaskToTaskList(){
        // Given
        var inputTask = new {
            description = "task"
        };
        // When
        Console.Task task = manager.AddTask(inputTask.description);
        // Then
        Assert.Equal(inputTask.description, task.Description);
    }
    [Fact]
    public void ShouldGetTaskInTaskList(){
        // Given
        var inputTask = new {
            description = "task"
        };
        // When
        Console.Task task = manager.AddTask(inputTask.description);
        Console.Task taskGetted = manager.GetTask(task.Id);
        // Then
        Assert.Equal(task, taskGetted);
    }
    [Fact]
    public void ShouldRemoveTaskInTheList(){
        // Given
        var inputTask = new {
            description = "task"
        };
        // When
        var task = manager.AddTask(inputTask.description);
        manager.RemoveTask(task.Id);
        var exception = Assert.Throws<Exception>(() => manager.RemoveTask(task.Id));
        // Then
        Assert.Equal("Task not found!", exception.Message);
    }
    [Fact]
    public void ShouldUpdateTaskInTheList(){
        // Given
        var inputTask = new {
            description = "task"
        };
        var updateTask = new {
            updateDescription = "task01"
        };
        // When
        var task = manager.AddTask(inputTask.description);
        manager.UpdateTask(task.Id, updateTask.updateDescription);
        var newTask = manager.GetTask(task.Id);
        // Then
        Assert.Equal(updateTask.updateDescription, newTask.Description);
    }
    [Fact]
    public void ShouldListTasksInTheList()
    {
        // Given
        var inputTask = new {
            description = "task"
        };
        // When
        Console.Task task = manager.AddTask(inputTask.description);
        var tasksListed = manager.ListTasks();
        // Then
        Assert.Equal($"{task.Id} {task.Description} {task.Completed}\n", tasksListed);
    }
}