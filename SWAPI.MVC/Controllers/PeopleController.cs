using Microsoft.AspNetCore.Mvc;

namespace SWAPI.MVC.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _httpClient;

        public PeopleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = httpClientFactory.CreateClient("swapi");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
