using System;

namespace TaskManagerApp
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } = "Pending"; 
        public DateTime? DueDate { get; set; }

        public override string ToString()
        {
            string due = DueDate.HasValue ? DueDate.Value.ToShortDateString() : "No due date";
            return $"Title: {Title}\nDescription: {Description}\nStatus: {Status}\nDue Date: {due}";
        }
    }
}
