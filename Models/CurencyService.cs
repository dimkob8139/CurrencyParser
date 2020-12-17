using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CurencyParcer.Models
{
    public class CurencyService : BackgroundService
    {
        private readonly IMemoryCache memoryCache;

        public CurencyService(IMemoryCache memoryCache)
        {
            this.memoryCache = memoryCache;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("ua-UA");
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    XDocument xml = XDocument.Load("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");
                    CurencyConverter curencyConverter = new CurencyConverter();
                    curencyConverter.USD = Convert.ToDecimal
                        (
                              xml.Elements("exchange")
                                     .Elements("currency")
                                     .FirstOrDefault(x => x.Element("r030")
                                      .Value == "840")
                                       .Element("rate")
                                        .Value
                        );

                    curencyConverter.EUR = Convert.ToDecimal
                       (
                             xml.Elements("exchange")
                                    .Elements("currency")
                                    .FirstOrDefault(x => x.Element("r030")
                                     .Value == "978")
                                      .Element("rate")
                                       .Value
                       );

                    curencyConverter.AUD = Convert.ToDecimal
                      (
                            xml.Elements("exchange")
                                   .Elements("currency")
                                   .FirstOrDefault(x => x.Element("r030")
                                    .Value == "36")
                                     .Element("rate")
                                      .Value
                      );

                    curencyConverter.CNY = Convert.ToDecimal
                      (
                            xml.Elements("exchange")
                                   .Elements("currency")
                                   .FirstOrDefault(x => x.Element("r030")
                                    .Value == "156")
                                     .Element("rate")
                                      .Value
                      );

                    curencyConverter.SEK = Convert.ToDecimal
                      (
                            xml.Elements("exchange")
                                   .Elements("currency")
                                   .FirstOrDefault(x => x.Element("r030")
                                    .Value == "752")
                                     .Element("rate")
                                      .Value
                      );

                    memoryCache.Set("key_currency", curencyConverter, TimeSpan.FromMinutes(1440));
                }
                catch (Exception)
                {

                    throw;
                }
            }

            await Task.Delay(3600000,stoppingToken);
        }

    }
}
