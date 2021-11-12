using System;
using FilmComments.DB.Model;
using Microsoft.EntityFrameworkCore;

namespace FilmComments.DB
{
    public class DbContextManager : DbContext
    {
        public DbSet<CommentEntity> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=thenetfish;Uid=root;Pwd=root";
            var version = new MySqlServerVersion(new Version(5, 7, 34));

            optionsBuilder.UseMySql(connectionString, version);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
