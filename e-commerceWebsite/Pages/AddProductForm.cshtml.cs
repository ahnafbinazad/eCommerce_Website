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
    public class AddProductFormModel : PageModel
    {
        [BindProperty]
        public Product product { get; set; }
        private readonly AppDataContext _db;
        public AddProductFormModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return RedirectToPage("/Product");
        }
    }
}
