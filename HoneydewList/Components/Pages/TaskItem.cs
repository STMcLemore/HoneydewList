namespace HoneydewList.Components.Pages
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public TaskPriority Priority { get; set; }  // Enum
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public TaskType Type { get; set; }// Enum for daily, weekly, monthly
        //public IEnumerable<TaskItem> TaskItems { get; set; }
    }

    public enum TaskPriority
    {
        Low, Medium, High
    }

    public enum TaskType
    {
        Daily, Weekly, Monthly
    }

}
