using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebGridDemo.Models;
using WebGridDemo.ModelView;

namespace WebGridDemo.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            var now = DateTime.Now;
            var monthNum = now.Month;
            var startOfMonth = new DateTime(now.Year, monthNum, 1);

            // Set start day as first Monday before the 1st (unless the 1st is a Monday)
            var day = startOfMonth.AddDays(1 - (int)startOfMonth.DayOfWeek);

            // Add days until we get to the first sunday in the next month
            var cal = new List<Day>();
            while (day.Month <= monthNum || (int) day.DayOfWeek != 1 )
            {
                var style = Dstyle.monthDay;
                if (day.Month != monthNum) { style = Dstyle.otherDay; }
                else
                {
                    if (day.Day == now.Day)
                    { style = Dstyle.today; }
                }
                cal.Add(new Day
                {
                    DOM = day.Day,
                    MonthDate = day,
                    DayStyle = style
                });

                day = day.AddDays(1);
            }

            // Add to View Model
            var vm = new Calendar
            {
                MonthName = ((Dmoy) monthNum).ToString(),
                MonthDays = cal
            };

            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
