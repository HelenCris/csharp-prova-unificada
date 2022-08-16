using Microsoft.EntityFrameworkCore; 
using CSharpProvaUnificada;

namespace biblioteca.Model.Connection {
   public class DatabaseConnection : DbContext 
   {
      public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
      public DbSet<User> Users { get; set; } 
      public DbSet<Book> Books { get; set; }           
   }
}

// define a configuração 
//          protected override void OnModelCreating(ModelBuilder builder){ 
//              builder.Entity<Livro>().Property( p => p.Id_livro).HasMaxLength(255); 
//              builder.Entity<Usuario>().Property( c => c.Matricula_usuario).HasMaxLength(255); 
//          } 
  
//          protected override void ConfigureConventions(ModelConfigurationBuilder builder){ 
//              builder.Properties<string>().HaveMaxLength(100); 
//          } 

