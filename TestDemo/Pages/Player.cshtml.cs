using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestDemo.Pages
{
    public class PlayerModel : PageModel
    {
        public List<string> player { get; set; }
        public void OnGet()
        {
            player = new List<string>();
            player.Add("Erik sanberg");
            player.Add("Anton karlsson");
            player.Add("Matias ledberg");
            player.Add("Sofia larsrson");
            player.Add("Maria jagobson");
        }
    }
}
