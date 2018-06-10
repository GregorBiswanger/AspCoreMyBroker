using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBroker.Models;
using System.ComponentModel.DataAnnotations;

namespace MyBroker.Pages
{
    public class NewStockModel : PageModel
    {
        [BindProperty]
        [Required, MinLength(3)]
        public string Stockname { get; set; } = "";

        private IStockDepot _stockDepot;

        public NewStockModel(IStockDepot stockDepot)
        {
            _stockDepot = stockDepot;
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _stockDepot.SaveStockname(Stockname);

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}