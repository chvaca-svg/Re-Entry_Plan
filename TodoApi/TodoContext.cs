using System;
using Microsoft.EntityFrameworkCore;


namespace TodoApi;

public class TodoContext : DbContext
{
    public DbSet<TodoItem> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("Todo_DataSource");
    }

}
