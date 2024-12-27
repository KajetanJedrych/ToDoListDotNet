using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Your Text exceeds the maximum character limit of 100.")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}
