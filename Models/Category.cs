namespace TrklPPR.Models;


public class Category
{
public int Id { get; set; }
public string Title { get; set; }
public ICollection<Dish> Dishes { get; set; } 
public ICollection<Drink> Drinks { get; set; } 
public ICollection<Discover> Discovers { get; set; }
}
