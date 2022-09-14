using Microsoft.EntityFrameworkCore;

namespace WebAppPractise.Models
{
    public class ToDoContext
    {
        internal IEnumerable<ToDoItem> TodoItems;

        public class TodoContext : DbContext
        {
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<ToDoItem> TodoItems { get; set; } = null!;


        }
    }
}
