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
    public class articlesModel : PageModel
    {
        public readonly IKrisInfoService _krisInfoService;
        public List<KrisInfo> articles { get; set; } = new List<KrisInfo>();

        public articlesModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }
        public void OnGet()
        {
            articles = _krisInfoService.GetAllKrisInformation().Take<KrisInfo>(10).ToList();
        }        
    }
}
