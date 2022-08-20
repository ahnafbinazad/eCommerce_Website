using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_commerce_website.Model;
using System.Text.RegularExpressions;

namespace e_commerce_website.Pages
{
    [Authorize(Roles = "AdminManager")]

    public class AdminDashModel : PageModel
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly UserManager<AppUser> _userManager;
        public List<IdentityRole> roles;
        public List<AppUser> users { get; set; }
        [BindProperty]
        public string newPassword { get; set; }

        [BindProperty]
        public string roleName { get; set; }
        [BindProperty(SupportsGet = true)]
        private string urlId { get; set; }
        public bool isValid;
        public AdminDashModel(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public async Task<IActionResult> OnGetDeleteAsync()
        {
            urlId = Request.Query["id"];

            var role = await _roleManager.FindByIdAsync(urlId);
            if (role != null)
            {
                var result = await _roleManager.DeleteAsync(role);
            }
            else
            {

                var user = await _userManager.FindByIdAsync(urlId);
                var result1 = await _userManager.DeleteAsync(user);
            }



            return RedirectToPage("/AdminDash");
        }






        public async Task<IActionResult> OnGetAsync()
        {

            roles = await _roleManager.Roles.ToListAsync();
            users = await _userManager.Users.ToListAsync();
            return Page();
        }




        public async Task<IActionResult> OnPostAsync()
        {
            string testRole = roleName.Trim();
            if (IsName(roleName))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName.Trim()));

                return RedirectToPage("/AdminDash");

            }
            isValid = false;
            ViewData["msg"] = $"Invalid role provided: {testRole}";

            return RedirectToPage("/AdminDash");


        }

        public async Task<IActionResult> OnPostUpdateAsync()
        {
            urlId = Request.Query["id"];
            if (newPassword.Length > 1)
            {
                var updateUser = await _userManager.FindByIdAsync(urlId);
                await _userManager.RemovePasswordAsync(updateUser);
                await _userManager.AddPasswordAsync(updateUser, newPassword);
            }



            return RedirectToPage("/AdminDash");
        }
        public bool IsName(string value)
        {
            string pattern = @"^[a-zA-Z]+$";
            Regex vRg = new Regex(pattern);

            return vRg.IsMatch(value);
        }




    }
}
