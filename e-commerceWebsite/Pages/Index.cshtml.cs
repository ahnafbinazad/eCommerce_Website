using e_commerce_website.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, AppDataContext db)
        {
            _logger = logger;
            _db = db;
        }

        
        [BindProperty]
        public string Search { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public IEnumerable<Product> product { get; set; }
        private readonly AppDataContext _db;

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
