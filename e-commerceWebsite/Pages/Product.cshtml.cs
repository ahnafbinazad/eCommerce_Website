using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce_website.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace e_commerce_website.Pages
{
    [Authorize(Roles = "AdminManager")]
    public class ProductModel : PageModel
    {
        [BindProperty]
        public string Search { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public IEnumerable<Product> product { get; set; }
        private readonly AppDataContext _db;

       

        public ProductModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            product = _db.Products.ToList();
        }
        public void OnPost()
        {
            product = _db.Products.Where(p=>p.Name.Contains(Search));
        }
        public IActionResult OnGetDelete()
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToPage("/Product");
        }
    }
}
