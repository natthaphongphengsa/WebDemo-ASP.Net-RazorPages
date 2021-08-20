using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDemo.Services
{
    public class LotteryService : ILotteryService
    {
        public Random randomnare = new Random();        
        public string GetWinningNumber()
        {
            string VinnareNumber = randomnare.Next(1, 10000000).ToString();
            return VinnareNumber;
        }
    }
}
