using System;
using Microsoft.EntityFrameworkCore;

namespace ASPCrud.Models
{
	public class StudentDbContex : DbContext
	{
		public StudentDbContex(DbContextOptions<StudentDbContex> options ):base(options)
		{
		}

		public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Lbs;User Id=SA;Password=Popill786@;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

    }
}

