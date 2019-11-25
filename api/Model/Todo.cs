using System;
using System.ComponentModel.DataAnnotations;

namespace api.Model
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Max length allowed is 250")]
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}
