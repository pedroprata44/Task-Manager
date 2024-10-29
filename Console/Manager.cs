namespace Console{
    public class Manager{
        public readonly List<Task> taskList = [];
        public Task AddTask(string description){
            Task task = new(description);
            taskList.Add(task);
            return task;
        }
        public string RemoveTask(Guid id){
            taskList.Remove(taskList.FirstOrDefault(t => t.Id == id) ?? throw new Exception("Task not found!"));
            return "";
        }
        public string UpdateTask(Guid Id, string description){
            Task task = taskList.FirstOrDefault(t => t.Id == Id) ?? throw new Exception("Task not found");
            task.Description = description;
            return "";
        }
        public string ListTasks(){
            string output = "";
            if(taskList.Count == 0) throw new Exception("List is Empty");
            foreach(Task task in taskList){
                output += $"{task.Id} {task.Description} {task.Completed}\n";
            }
            return output;
        }
    }
}