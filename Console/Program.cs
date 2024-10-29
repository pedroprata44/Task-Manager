namespace Console{
    public class Program{
        static void Main(string[] args){
            Manager manager = new();
            manager.AddTask("task 1");
            System.Console.WriteLine(manager.ListTasks());
        }
    }
}