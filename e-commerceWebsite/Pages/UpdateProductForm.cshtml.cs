using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce_website.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace e_commerce_website.Pages
{
    [Authorize(Roles = "AdminManager")]
    public class UpdateProductFormModel : PageModel
    {
        [BindProperty]
        public Product product { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        private readonly AppDataContext _db;
        public UpdateProductFormModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            product = _db.Products.Find(Id);
        }
        public IActionResult OnPost()
        {
            _db.Products.Update(product);
            _db.SaveChanges();
            return RedirectToPage("/Product");
        }
    }
}

