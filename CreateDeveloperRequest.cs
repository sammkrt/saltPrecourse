using System.ComponentModel.DataAnnotations;
namespace webapiDotNetTrainingGround;
public class CreateDeveloperRequest
{
    [Required][MinLength(3)]
    public string? Name { get; set; }
    [Required(ErrorMessage = "The 'Email' needs to be supplied in the request body")][EmailAddress]
    public string? Email { get; set; }
}