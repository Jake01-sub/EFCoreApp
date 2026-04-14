using System.ComponentModel.DataAnnotations;

namespace EFCoreDomain.Models
{
    public class BaseClass
    {
        [Key] public Guid Id { get; set; }
    }
}
