using KaldAndCocaine.Models.Drivers;
using Microsoft.AspNetCore.Mvc;

namespace KaldAndCocaine.Controllers
{
    public class DriverController : Controller
    {
        public IActionResult Index()
        {
            List<DriverViewModel> drivers = new List<DriverViewModel>();

            DriverViewModel driver = new DriverViewModel();
            driver.Id = 3;
            driver.FirstName = "Khalid";
            driver.LastName = "Kata";
            driver.DateOfBirth = new DateTime(1993, 12, 12);
            drivers.Add(driver);

            DriverViewModel driver2 = new DriverViewModel();
            driver2.Id = 17;
            driver2.FirstName = "Khalid";
            driver2.LastName = "Kata";
            driver2.DateOfBirth = new DateTime(1993, 12, 12);
            drivers.Add(driver2);

            return View(drivers);
        }

        public IActionResult DriverDetails()
        {
            DriverViewModel driver = new DriverViewModel();
            driver.Id = 17;
            driver.FirstName = "Sameer";
            driver.LastName = "Abu Laila";
            
            driver.DateOfBirth = new DateTime(1994, 8, 25);

            return View(driver);
        }
    }
}
