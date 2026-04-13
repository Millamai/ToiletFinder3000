using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToiletFinder3000.Model;

namespace ToiletFinder3000.Pages
{
    public class DetailsModel : PageModel
    {

        public Toilet WC { get; set; }

        private ToiletService _toiletService;

        public DetailsModel(ToiletService ts)
        {
            _toiletService = ts;

        }

        public void OnGet(int id)
        {
            WC = _toiletService.GetToilet(id);

        }
    }
}
