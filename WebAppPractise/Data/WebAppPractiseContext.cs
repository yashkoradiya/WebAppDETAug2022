using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppPractise.Models;

namespace WebAppPractise.Data
{
    public class WebAppPractiseContext : DbContext
    {
        public WebAppPractiseContext (DbContextOptions<WebAppPractiseContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPractise.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
