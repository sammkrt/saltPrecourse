using System.ComponentModel.DataAnnotations;
namespace webapiDotNetTrainingGround.Models;

public class Developer {
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Email { get; set; }
    
}
