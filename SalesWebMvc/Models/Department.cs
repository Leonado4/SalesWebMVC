using System.ComponentModel.DataAnnotations;
namespace SalesWebMvc.Models
{
    public class Department
    {
        [Display(Name = "Cod")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
