using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.DAL.Context
{
    public class MyPortfolioContext : DbContext

    {
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; initial Catalog=MyPortfolioDb;integrated Security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials  { get; set; }
        public DbSet<ToDoList> ToDoLists  { get; set; }// Oluşturduğumuz yeni tabloyu migrastiona eklemek için önce contexte ekliyoruz. Add migation * Migration adı* ile mig oluşturupo sonrasında ise updatge-migration ile bunun sql ile olan ilkişkisini gerçekleştiriyoruz.

    }
}
