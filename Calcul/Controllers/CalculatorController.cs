using Calcul.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calcul.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(double a, double b, string operation)
        {
            try
            {
                var op = OperationFactory.CreateOperation(operation);
                var result = op.Execute(a, b);
                ViewBag.Result = result;
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
            }
            return View("Index");
        }
    }

}
