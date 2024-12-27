namespace ToDoList.ViewModels
{
    public class TaskItemViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public int CategoryId { get; set; }
    }
}
