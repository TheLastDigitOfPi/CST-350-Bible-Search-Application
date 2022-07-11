using Microsoft.AspNetCore.Mvc;
using Bible_Search_Application.Models;
using Bible_Search_Application.Services;
using System.Diagnostics;

namespace Bible_Search_Application.Controllers
{
    public class VerseSearchController : Controller
    {
        public IBibleVerseDataService repository { get; set; }
        public VerseSearchController(IBibleVerseDataService dataService)
        {
            repository = dataService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllVerses()
        {
            return View(repository.AllVerses());
        }

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult SearchResults(BibleVerse searchVerse)
        {
            //Uncomment for Debug Purposes
            //Debug.WriteLine(searchVerse.ToString());
            
            return View(repository.SearchVerses(searchVerse));
        }

    }
}
