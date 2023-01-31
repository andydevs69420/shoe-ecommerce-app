using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace shoe_ecommerce.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required, NotNull]
    public string Name { get; set; }
    [Required, NotNull]
    public string Password { get; set; }
    [Required, NotNull]
    public string Email { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}