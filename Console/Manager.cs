namespace Console{
    public class Manager{
        public readonly List<Task> tasks = [];
        public Task AddTask(string description){
            Task task = new(description);
            tasks.Add(task);
            return task;
        }
        public string RemoveTask(Guid id){
            tasks.Remove(tasks.FirstOrDefault(t => t.Id == id) ?? throw new Exception("Task not found!"));
            return "";
        }
        public string UpdateTask(Guid Id, string description){
            Task task = tasks.FirstOrDefault(t => t.Id == Id) ?? throw new Exception("Task not found");
            task.Description = description;
            return "";
        }
        public string ListTasks(){
            string taskList = "";
            if(tasks.Count == 0) throw new Exception("List is Empty");
            foreach(Task task in tasks){
                taskList += $"{task.Id} {task.Description} {task.Completed}\n";
            }
            return taskList;
        }
    }
}