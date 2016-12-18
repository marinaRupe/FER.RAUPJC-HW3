using System.Data.Entity;

namespace TodoRepository
{
    public class TodoDbContext : System.Data.Entity.DbContext
    {
        public IDbSet<TodoItem> TodoItems { get; set; }

        public TodoDbContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TodoItem>().HasKey(t => t.Id);
            modelBuilder.Entity<TodoItem>().Property(t => t.Text).IsRequired();
            modelBuilder.Entity<TodoItem>().Property(t => t.IsCompleted).IsRequired();
            modelBuilder.Entity<TodoItem>().Property(t => t.DateCreated).IsRequired();
            modelBuilder.Entity<TodoItem>().Property(t => t.UserId).IsRequired();
        }
    }
}