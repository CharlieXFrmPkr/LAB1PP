using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Request.Method.Equals("POST", System.StringComparison.OrdinalIgnoreCase))
            {
                if (Request.Form["Add"] == "Add")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) + double.Parse(Request.Form["num2"]);
                }

                if (Request.Form["Subtract"] == "Subtract")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) - double.Parse(Request.Form["num2"]);
                }

                if (Request.Form["Square"] == "Square")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]);
                }

                if (Request.Form["Multiply"] == "Multiply")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num2"]);
                }

                if (Request.Form["Power"] == "Power")
                {
                    ViewData["Result"] = Math.Pow(double.Parse(Request.Form["num1"]), double.Parse(Request.Form["num2"]));
                }

                if (Request.Form["Divide"] == "Divide")
                {
                ViewData["Result"] = double.Parse(Request.Form["num1"]) /double.Parse(Request.Form["num2"]);
                
                }

                if (Request.Form["Cube"] == "Cube")
                {
                    ViewData["Result"] = double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]) * double.Parse(Request.Form["num1"]);
                }
            }
        }
    }
}
