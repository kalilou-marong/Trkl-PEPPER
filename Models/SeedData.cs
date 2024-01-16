using TrklPPR.Models;
using System;
using System.Linq;
namespace TrklPPR.Data;
public static class SeedData
{
    public static void Initialize(TrklPPRContext context)
    {
        // DB Category

        context.Database.EnsureCreated();
        if (context.Categories.Any())
        {
            return; // DB has been seeded
        }
        var categories = new Category[]
        {
 new Category { Id=1, Title="Entrée"},
 new Category { Id=2, Title="Plat"},
 new Category { Id=3, Title="Dessert"},
 new Category { Id=4, Title="Boissons sans alcool"},
 new Category { Id=5, Title="Apéritifs"},
 new Category { Id=1, Title="Bières et vins"},
 new Category { Id=6, Title="Alcools forts, spiritueux, digestifs"},
 new Category { Id=7, Title="Entrées"},
 new Category { Id=8, Title="Plats"},
 new Category { Id=9, Title="Desserts"}

 // Ajoute d'autres tâches ici
        };
        foreach (Category t in categories)
        {
            context.Categories.Add(t);
        }
        context.SaveChanges();
        // Répète le processus pour les catégories si nécessaire

        // DB Dish

        if (context.Dishes.Any())
        {
            return; 
        }
        var dishes = new Dish[]
        {
new Dish { Title="Carpaccio de bœuf", Description="Tranches fines de bœuf, vinaigrette au poivre noir", Price=10, CategoryId=1},
new Dish { Title="Velouté de potiron", Description="Potiron et poivre de Sichuan", Price=8, CategoryId=1},
new Dish { Title="Crevettes sautées", Description="Crevettes sautées, crème fraîche et poivre vert", Price=12, CategoryId=1},
new Dish { Title="Salade de chèvre", Description="Salade, fromage de chèvre, et vinaigrette au poivre blanc", Price=9, CategoryId=1},
new Dish { Title="Tartare de saumon", Description="Tartare de saumon et poivre de Sichuan", Price=14, CategoryId=1},
new Dish { Title="Steak", Description="Steak de bœuf, sauce au poivre, accompagnement frite et salade", Price=18, CategoryId=2},
new Dish { Title="Poulet rôti", Description="Cuisse de poulet rôti, sauce au poivre rouge, accompagnement salade et frite", Price=15, CategoryId=2},
new Dish { Title="Pâtes aux fruits de mer", Description="Tagliatelles, moules, crevettes, calamars et sauce au poivre blanc", Price=20, CategoryId=2},
new Dish { Title="Ragoût de légumes et lentilles aux herbes", Description="Légumes de saisons, lentilles, cumin, paprika, curcuma et sauce au poivre noir", Price=16, CategoryId=2},
new Dish { Title="Filet de canard au miel", Description="Canard grillé, glaçage au miel et sauce au poivre rose et pommes de terre rôti au thym", Price=22, CategoryId=2},
new Dish { Title="Tarte au chocolat", Description="Ganache chocolat noir, noisettes croquantes et poivre rose", Price=7, CategoryId=3},
new Dish { Title="Glace Vanille/Caramel", Description="Glace crémeuse, poivre long et coulis au choix*", Price=6, CategoryId=3},
new Dish { Title="Poires pochées", Description="Poire pochée au sirop, arôme poivre de Jamaïque et coulis au choix*", Price=9, CategoryId=3},
new Dish { Title="Crème brûlée", Description="Crème arôme vanille brûlée et poivre noir", Price=8, CategoryId=3},
new Dish { Title="Soufflé aux fruits", Description="Fruits de saison, sel, poivre vert et noix de muscade", Price=10, CategoryId=3}
        };
      
        foreach (Dish t in dishes)
        {
            context.Dishes.Add(t);
        }
        context.SaveChanges();

        // DB Dish
        if (context.Drinks.Any())
        {
            return; 
        }
        var drinks = new Drink[]
        {
new Drink { Name="Eau plate", Price=2M, CategoryId=4},
new Drink { Name="Eau pétillante", Price=2.5M, CategoryId=4},
new Drink { Name="Soda", Price=3M, CategoryId=4},
new Drink { Name="Jus de fruit", Price=3.5M, CategoryId=4},
new Drink { Name="Sirop", Price=2.5M, CategoryId=4},
new Drink { Name="Cocktail poivré", Price=8M, CategoryId=5},
new Drink { Name="Margarita au poivre", Price=10M, CategoryId=5},
new Drink { Name="Gin & Poivre", Price=9M, CategoryId=5},
new Drink { Name="Old Fashioned poivré", Price=12M, CategoryId=5},
new Drink { Name="Spritz au poivre", Price=11M, CategoryId=5},
new Drink { Name="Bière blonde locale", Price=4.5M, CategoryId=6},
new Drink { Name="IPA Artisanale", Price=5M, CategoryId=6},
new Drink { Name="Pilsner", Price=4M, CategoryId=6},
new Drink { Name="Vin rouge de la région", Price=6M, CategoryId=6},
new Drink { Name="Vin blanc de la région", Price=5M, CategoryId=6},
new Drink { Name="Whisky", Price=7M, CategoryId=7},
new Drink { Name="Rhum ambré", Price=7.5M, CategoryId=7},
new Drink { Name="Tequila", Price=8M, CategoryId=7},
new Drink { Name="Cognac", Price=8M, CategoryId=7},
new Drink { Name="Chartreuse", Price=10M, CategoryId=7}
        };
      
        foreach (Drink t in drinks)
        {
            context.Drinks.Add(t);
        }
        context.SaveChanges();

        // DB Employee
        if (context.Employees.Any())
        {
            return; 
        }
        var employees = new Employee[]
        {
new Employee { FirstName="Marc", LastName="Dubois", PathImg=null, Role="Propriétaire", HireDate= new DateTime(1992, 4, 17)},
new Employee { FirstName="Alice", LastName="Smith", PathImg=null, Role="Gérante", HireDate= new DateTime(1999, 02, 15)},
new Employee { FirstName="Emma", LastName="Johnson", PathImg=null, Role="Commis cuisine", HireDate= new DateTime(2019, 3, 10)},
new Employee { FirstName="Michael", LastName="Williams", PathImg=null, Role="Chef cuisinier", HireDate= new DateTime(2012, 4, 20)},
new Employee { FirstName="Sophie", LastName="Brown", PathImg=null, Role="Comptable", HireDate= new DateTime(2020, 5, 5)},
new Employee { FirstName="David", LastName="Lee", PathImg=null, Role="Serveur", HireDate= new DateTime(2022, 6, 30)},
new Employee { FirstName="Laura", LastName="Garcia", PathImg=null, Role="Plongeur", HireDate= new DateTime(2021, 7, 15)},
new Employee { FirstName="Alex", LastName="Johnson", PathImg=null, Role="Barman", HireDate= new DateTime(2004, 09, 27)},
new Employee { FirstName="Sophie", LastName="Martin", PathImg=null, Role="Serveuse", HireDate= new DateTime(2019, 6, 23)},
new Employee { FirstName="Thomas", LastName="Leroy", PathImg=null, Role="Responsable de communication", HireDate= new DateTime(2023, 09, 27)}
        };
    
        foreach (Employee t in employees)
        {
            context.Employees.Add(t);
        }
        context.SaveChanges();

        // DB Discover
        if (context.Discovers.Any())
        {
            return; 
        }
        var discovers = new Discover[]
        {
new Discover { Name="Vole-au-vent", Description="Vole-au-vent de volaille jaune, oignons caramélisés, carottes, émulsion de poivre vert", Price=7.5M, CategoryId=8},
new Discover { Name="Saumon gravlax", Description="Saumon gravlax, tuile de parmesan au poivre, mousse de poivre blanc et aneth", Price=8.5M, CategoryId=8},
new Discover { Name="Turbot braisé", Description="Turbot braisé, fumet de poisson au poivre, tagliatelles, chips de carottes", Price=8.5M, CategoryId=9},
new Discover { Name="Carré d''agneau", Description="Carré d''agneau, pommes dauphines, fenouil rôti, émulsion de poivre, jus serré d''agneau", Price=9M, CategoryId=9},
new Discover { Name="Dôme chocolat", Description="Dôme chocolat noir, mousse de fruits rouges, sirop au poivre de jamaïque, pralin pistache et poivre vert", Price=6.5M, CategoryId=10},
new Discover { Name="Déclinaison de citron", Description="Dacquoise coco et citron vert, gel yuzu et poivre de jamaïque, citron caviar et émulsion de poivre vert", Price=7M, CategoryId=10}

        };

        foreach (Discover t in discovers)
        {
            context.Discovers.Add(t);
        }
        context.SaveChanges();

        // DB Review
        if (context.Reviews.Any())
        {
            return; 
        }
        var reviews = new Review[]
        {
new Review { Name="Daniel", Rating=5, Commentaire="J'ai récemment découvert ce restaurant et j'ai été agréablement surpris par la variété de plats au poivre qu'ils proposent. Des entrées aux desserts, chaque bouchée était une explosion de saveurs. Ambiance parfaite pour une soirée délicieusement épicée."},
new Review { Name="Richard", Rating=5, Commentaire="En tant qu'amateur de plats épicés, j'ai été comblé par ce restaurant spécialisé dans le poivre. Les chefs maîtrisent l'art d\"équilibrer la chaleur du poivre avec d\"autres saveurs. Le service était également impeccable."},
new Review { Name="Isabelle", Rating=5, Commentaire="Ce restaurant m'a transportée dans un voyage gustatif unique. Chaque plat était une exploration de différentes variétés de poivre, apportant une profondeur de saveur que je n'avais jamais connue auparavant. Je recommande vivement cet endroit à tous les amateurs de cuisine audacieuse."},
new Review { Name="Julia", Rating=5, Commentaire="J'ai eu le plaisir de choisir le menu découverte de ce restaurant, et je suis encore sous le charme de cette expérience culinaire. Le menu était parfaitement équilibré, avec des créations originales mettant en valeur chaque ingrédient. Le chef a clairement un talent exceptionnel pour harmoniser les goûts et les textures!"}

        };

       foreach (Review t in reviews)
        {
            context.Reviews.Add(t);
        }
        context.SaveChanges();
    }
}

