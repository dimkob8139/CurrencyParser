using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurencyParcer.Models
{
    public class CurencyConverter
    {
        

        public decimal USD { get; set; }
        public decimal convertToUSD(decimal priceUAH) => priceUAH / USD;

        public decimal EUR { get; set; }
        public decimal convertToEUR(decimal priceUAH) => priceUAH / EUR;

        public decimal AUD { get; set; }
        public decimal convertToAUD(decimal priceUAH) => priceUAH / AUD;

        public decimal CNY { get; set; }
        public decimal convertToCNY(decimal priceUAH) => priceUAH / CNY;

        public decimal SEK { get; set; }
        public decimal convertToSEK(decimal priceUAH) => priceUAH / SEK;
    }
}
