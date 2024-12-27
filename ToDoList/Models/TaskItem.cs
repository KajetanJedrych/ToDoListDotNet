using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
    public class TaskItem
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your Text exceeds the maximum character limit of 100.")]
        public string Title { get; set; }
        [StringLength(250, ErrorMessage = "Your Text exceeds the maximum character limit of 250.")]
        public string Description { get; set; }
        [Required]
        public TaskStatus Status { get; set; }
        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}

