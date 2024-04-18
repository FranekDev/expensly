using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expensly.Library.Models;

public sealed class User
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string UserName { get; set; }
    
    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }
    
    [Required]
    [StringLength(50)]
    public string LastName { get; set; }
    
    [Required]
    [StringLength(254)]
    public string Email { get; set; }
    
    [Required]
    [StringLength(128)]
    public string Password { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}