using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace WebAppDETAug2022.Pages
{
    public class helowebModel : PageModel
    {
        public string Message { get; set; }
        public string Discount { get; set; }
        public string Person { get; set; }
        public void OnGet()
        {
            Message = "ASP.Net core is set";
            Discount = "15";
           
        }
    }
}
