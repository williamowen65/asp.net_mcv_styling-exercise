using Microsoft.AspNetCore.Mvc;
using ModelBindingStyling_Lab.Models;
using System.Diagnostics;

namespace ModelBindingStyling_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserProfile()
        {
            UserProfile user = GetUserProfileData();
            return View(user);
        }

        /// <summary>
        /// This method returns hardcoded data for a UserProfile
        /// to use with modelbinding on a view
        /// </summary>
        private UserProfile GetUserProfileData()
        {
            return new UserProfile()
            {
                DateOfBirth = new DateOnly(1815, 7, 1),
                Email = "First.Programmer@gmail.com",
                FullName = "Ada Lovelace",
                GitHubUrl = "https://github.com/Octocat",
                ImageUrl = "https://via.placeholder.com/150",
                PhoneNumber = "(253) 555-1234",
                UserProfileId = 10,
                SkilledLanguages = new List<string> { "C#", "Java", "C++" }
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}