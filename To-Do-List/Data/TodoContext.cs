using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using To_Do_List.Models;

namespace To_Do_List.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }

}
