using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TrklPPR.Models;
using TrklPPR.Data;
using TrklPPR.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TrklPPR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TrklPPRContext _context;

        public HomeController(ILogger<HomeController> logger, TrklPPRContext context)
        {
            _logger = logger;
            _context = context;

        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                // Chargement des produits depuis la base de donnée
                Categories = await _context.Categories.Include(c => c.Dishes).Include(c => c.Drinks).Include(c => c.Discovers).ToListAsync(),
                Employees = await _context.Employees.ToListAsync(),
                Dishes = await _context.Dishes.Include(d => d.Category).ToListAsync(),
                Drinks = await _context.Drinks.ToListAsync(),
                Discovers = await _context.Discovers.ToListAsync(),
                Reviews = await _context.Reviews.ToListAsync(),
                ContactForm = new ContactForm(),
                ReservationForm = new ReservationForm()
            };
            // Envoi du ViewModel à la vue
            return View(viewModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        // [HttpPost]
        // public IActionResult Contact(ContactForm contactForm)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         // Traiter le formulaire
        //         TempData["SuccessMessage"] = "Merci pour votre message ! Nous vous contacterons bientôt.";
        //         return RedirectToAction("Index");
        //     }
        //     return View(contactForm);
        // }

        public IActionResult Reservations()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reservations([Bind("FirstName, LastName, Email, PhoneNumber, Message, Date, NbPeople")] ReservationForm reservations)
        {
            if (ModelState.IsValid)
            {
                // Traiter les données de réservation ici
                _context.Add(reservations);
                await _context.SaveChangesAsync();
                Console.WriteLine("Envoyé !");
                TempData["SuccessMessage"] = "Votre message a bien été envoyé !";
                return View();
            }
            Console.WriteLine("NTM !");
            return View(reservations);
        }

       
    }
}
