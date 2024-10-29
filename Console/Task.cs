namespace Console{
    public class Task(string description){
        public Guid Id = Guid.NewGuid();
        public string Description = description;
        public bool Completed = false;
    }
}