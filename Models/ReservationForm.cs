namespace TrklPPR.Models;
using System.ComponentModel.DataAnnotations;

public class ReservationForm
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string FirstName { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string LastName { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 10)]
    [EmailAddress]
    [RegularExpression(@"^[a-zA-Z]+$")]
    public string Email { get; set; }
    [Required]
    [StringLength(10, MinimumLength = 10)]
    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Le numéro de téléphone doit être un numéro local à 10 chiffres.")]
    public string PhoneNumber { get; set; }
    [StringLength(300, MinimumLength = 10)]
    public string Message { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public int NbPeople { get; set; }
}