 using Microsoft.EntityFrameworkCore;
 using projetoRenova.Models; 

 namespace projetoRenova.Data{
     public class DataContext : DbContext{
        public DataContext(DbContextOptions<DataContext> options)
         : base(options)
         {

        }

         public DbSet<Items> Items{get;set;}
         
         public DbSet<Points> Points{get;set;}

         public DbSet<Points> Category{get;set;}
     }
 }