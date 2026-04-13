using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using ToiletFinder3000.Model;
using ToiletFinder3000.Repository;

namespace ToiletFinder3000.Pages
{
    public class IndexModel : PageModel
    {


        public List<Toilet> Toilets { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, ToiletService service)
        {
            _logger = logger;
            //      Toilets = toiletRepository.GetAll();
            Toilets = service.GetAll();

        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

            //Slet
            Debug.WriteLine("Noget sækal slettes");
        }


        public void OnPostAddRating()
        {

            //Slet
            Debug.WriteLine("Rating skal sættes");
        }
    }
}
