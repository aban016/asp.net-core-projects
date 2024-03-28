using System.ComponentModel.DataAnnotations;

namespace Crud_application.Model
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Education { get; set;}
        [Required]
        public string Address { get; set; }
    }
}
