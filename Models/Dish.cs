namespace TrklPPR.Models;

    public class Dish
    {

      public int Id {get; set;}
      public string Title {get; set;}
      public string Description {get; set;}
      public decimal Price {get; set;}  

      public int CategoryId {get; set;}
      public Category Category {get; set;}

    }
