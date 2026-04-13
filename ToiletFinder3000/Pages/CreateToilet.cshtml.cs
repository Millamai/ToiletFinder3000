using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using ToiletFinder3000.Model;

namespace ToiletFinder3000.Pages
{
    public class CreateToiletModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string HouseNumber { get; set; }
        [BindProperty]
        public string StreetName { get; set; }
        [BindProperty]
        public string PostCode { get; set; }
        [BindProperty]
        public string City { get; set; }


        [BindProperty]
        public double Longitude { get; set; }


        [BindProperty]
        public double Latitude { get; set; }

        private ToiletService _toiletService;
        public CreateToiletModel(ToiletService service)
        {
            _toiletService = service;
        }


        // public 
        public IActionResult OnPost()
        {

            Address a = new Address(StreetName, HouseNumber, PostCode, City, Longitude, Latitude);

            Toilet t = new Toilet(Name, a);

            _toiletService.Add(t);

            return Redirect("/Index");
        }
    }
}
