using System.ComponentModel.DataAnnotations;

namespace EFCoreDomain.Models
{
    public class Product : BaseClass
    {
        [Required] public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
