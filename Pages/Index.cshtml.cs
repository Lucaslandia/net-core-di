using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using App.Models;
using App.Interfaces;

namespace App.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _userRepository;
        public IndexModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }

        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = _userRepository.GetAll();
        }
    }
}
