using Microsoft.EntityFrameworkCore;
using KellyTestProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using static KellyTestProject.AppCode.Helper;

namespace KellyTestProject.DBContext
{
    public class MsSqlContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public MsSqlContext(DbContextOptions<MsSqlContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Surname = "Иванов", Name = "Иван", Patronymic = "Иванович" },
                new User { Id = 2, Surname = "Петров", Name = "Пётр", Patronymic = "Петрович" },
                new User { Id = 3, Surname = "Смирнов", Name = "Семён", Patronymic = "Семёныч" },
                new User { Id = 4, Surname = "Александров", Name = "Александр", Patronymic = "Александрович" },
                new User { Id = 5, Surname = "Максимов", Name = "Максим", Patronymic = "Максимы" },
                new User { Id = 6, Surname = "Фамилия1", Name = "Имя1", Patronymic = "Отчество1" },
                new User { Id = 7, Surname = "Фамилия2", Name = "Имя2", Patronymic = "Отчество2" },
                new User { Id = 8, Surname = "Фамилия3", Name = "Имя3", Patronymic = "Отчество3" },
                new User { Id = 9, Surname = "Фамилия4", Name = "Имя4", Patronymic = "Отчество4" },
                new User { Id = 10, Surname = "Фамилия5", Name = "Имя5", Patronymic = "Отчество5" },
                new User { Id = 11, Surname = "Фамилия6", Name = "Имя6", Patronymic = "Отчество6" },
                new User { Id = 12, Surname = "Фамилия7", Name = "Имя7", Patronymic = "Отчество7" },
            };
            modelBuilder.Entity<User>().HasData(users);
            List<Section> sections = new List<Section>
            {
                new Section{ Id = 1, Name = "Раздел 1" },
                new Section{ Id = 2, Name = "Раздел 2" },
                new Section{ Id = 3, Name = "Раздел 3" },
                new Section{ Id = 4, Name = "Раздел 4" },
                new Section{ Id = 5, Name = "Раздел 5" },
            };

            modelBuilder.Entity<Section>().HasData(sections);

            int visitId = 1;
            var random = new Random();

            List<Visit> vists = new List<Visit>();

            foreach (var section in sections)
            {
                foreach (var user in users)
                {
                    for (int i = 0; i < random.Next(0, 10); i++)
                    {
                        modelBuilder.Entity<Visit>().HasData(new { DateTimeVisit = GetRandomDate(), Id = visitId++, SectionId = section.Id, UserId = user.Id });
                    }
                }
            }
            var visitsAn = vists.Select(x => new { DateTimeVisit = x.DateTimeVisit, Id = x.Id, Section = x.Section, SectionId = x.SectionId, User = x.User, UserId = x.UserId });
            modelBuilder.Entity<Visit>().HasData(visitsAn);
        }
    }
}
