using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce_website.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace e_commerce_website.Pages
{
    public class ItemsModel : PageModel
    {
        [BindProperty]
        public string Search { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public IEnumerable<Product> product { get; set; }
        private readonly AppDataContext _db;



        public ItemsModel(AppDataContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            product = _db.Products.ToList();
        }
        public void OnPost()
        {
        
            product = _db.Products.Where(p => p.Name.Contains(Search));

            
        }
        public IActionResult OnGetDelete()
        {
            _db.Remove(_db.Products.Find(Id));
            _db.SaveChanges();
            return RedirectToPage("/Product");
        }
    }
}
