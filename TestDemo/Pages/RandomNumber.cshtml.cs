using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestDemo.Pages
{
    public class RandomNumberModel : PageModel
    {
        public Random randomnare { get; set; }
        public int Number { get; set; }
        public string datetime { get; set; }

        public void OnGet()
        {
            randomnare = new Random();
            Number = randomnare.Next(0, 300000);

            datetime = DateTime.Now.ToString("HH:mm");
        }
    }
}
