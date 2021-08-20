using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestDemo.Interfaces;
using TestDemo.Model;

namespace TestDemo.Pages
{
    public class showarticleModel : PageModel
    {
        public readonly IKrisInfoService _krisInfoService;
        public List<KrisInfo> articles { get; set; } = new List<KrisInfo>();

        public List<DateTime> Datum { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public string LinkUrl { get; set; }
        public int Displaymode { get; set; }
        public bool Emergency { get; set; }

        public showarticleModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }
        public void OnGet(string id)
        {
            var article = _krisInfoService.GetKrisInformation(id);
            Title = article.Title;
            Text = article.Text;
            ImageUrl = article.ImageUrl;
            LinkUrl = article.LinkUrl;
            Displaymode = article.Displaymode;
            Emergency = article.Emergency;
        }
    }
}
