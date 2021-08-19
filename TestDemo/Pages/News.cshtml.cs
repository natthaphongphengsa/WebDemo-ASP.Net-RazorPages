using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestDemo.Pages
{
    public class News
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string description { get; set; }
        public string Link { get; set; }
    }
    public class NewsModel : PageModel
    {
        public List<News> news { get; set; }

        public void OnGet()
        {
            news = new List<News>();
            for (int i = 0; i < 10; i++)
            {
                news.Add(new News
                {
                    Title = "Stora översvämningar i Gävle – kraftiga skyfall",
                    Image = "svtstatic.se/image/wide/992/32218159/1629293032?format=auto",
                    description = "Flera viadukter och byggnader har översvämmats i Gävleborgs län. I Gävle har det kommit 161,6 millimeter regn från klockan åtta i går tisdag till klockan åtta i dag, onsdag. Bara under natten har räddningstjänsten tagit emot runt 400 larmsamtal om översvämningar i området.",
                    Link = "https://www.svt.se/nyheter/lokalt/gavleborg/stora-oversvamningar-allmanheten-varnas",
                });
            }

        }
    }
}
