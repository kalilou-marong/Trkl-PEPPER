namespace TrklPPR.Models;
using System.ComponentModel.DataAnnotations;

public class ContactForm {
    public int Id { get; set;}

    [Required]
    [StringLength(100, MinimumLength = 10)]
    public string FirstName { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 10)]
    public string LastName { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 10)]
    [EmailAddress]
    [RegularExpression(@"^[a-zA-Z]+$")]
    public string Email { get; set; }
    [Required]
    [Range(1000000000, 9999999999, ErrorMessage = "Le numéro de téléphone doit être un numéro local à 10 chiffres.")]
    public string PhoneNumber { get; set; }
    [Required]
    public string Subject { get; set;}
    [Required] 
    [StringLength(300, MinimumLength = 10)]
    public string Message { get; set; }
}