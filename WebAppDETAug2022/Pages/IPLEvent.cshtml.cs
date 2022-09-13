using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;


namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Tickets> Ticket { get; set; }
        public void OnGet()
        {
            Ticket = new List<Tickets>{
            new Tickets{Category="PlatinumPlus",Price=5000,MaxLimit=200000},
            new Tickets{Category="Platinum",Price=4000,MaxLimit=300000},
            new Tickets{Category="Gold",Price=3000,MaxLimit=500000},
            new Tickets{Category="Silver",Price=2000,MaxLimit=500000},
            new Tickets{Category="General",Price=8000,MaxLimit=100000}
            };
        }
    }
}
