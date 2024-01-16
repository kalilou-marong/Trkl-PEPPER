using TrklPPR.Models;
using System.Collections.Generic;


namespace TrklPPR.ViewModels
{

  // ViewModel pour la page d'accueil
  public class HomeViewModel
  {
    // Liste des produits
    public List<Category> Categories { get; set; }
    public List<Employee> Employees { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Dish> Dishes { get; set; }
    public List<Drink> Drinks { get; set; }
    public List<Discover> Discovers { get; set;}
    public ContactForm ContactForm { get; set; }
    public ReservationForm ReservationForm { get; set; }

     public HomeViewModel()
    {
      Categories = new List<Category>();
      Dishes = new List<Dish>();
      Drinks = new List<Drink>();
      Discovers = new List<Discover>();
      Employees = new List<Employee>();
      Reviews = new List<Review>();
      ContactForm = new ContactForm();
      ReservationForm = new ReservationForm();
    }
  }

}
