using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestDemo.Services;

namespace TestDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILotteryService _lotteryService;

        public string WinnerNumber { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ILotteryService lotteryService)
        {
            _logger = logger;
            _lotteryService = lotteryService;
        }

        public void OnGet()
        {
            WinnerNumber = _lotteryService.GetWinningNumber();
        }
    }
}
