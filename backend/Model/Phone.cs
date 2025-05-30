using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace backend.Model;

public class Phone
{
    
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int phoneId { get; set; }
    [Required, MaxLength(9) , MinLength(9)]
    public string phoneNumber { get; set; }
    [Required, MaxLength(15)]
    public string phoneName { get; set; }
}