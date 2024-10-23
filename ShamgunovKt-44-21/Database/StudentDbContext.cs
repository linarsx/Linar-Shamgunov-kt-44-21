using Microsoft.EntityFrameworkCore;
using ShamgunovKt_44_21.Database.Configuration;
using ShamgunovKt_44_21.Models;

namespace ShamgunovKt_44_21.Database
{
    public class StudentDbContext : DbContext
    {
        //Добавляем таблицы
        DbSet<Student> Students { get; set; }
        DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) :base(options) 
        {
        }

    }
}
