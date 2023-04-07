using System;
using Microsoft.EntityFrameworkCore;

namespace ASPCrud.Models
{
	public class StudentDbContex : DbContext
	{
		public StudentDbContex(DbContextOptions options ):base(options)
		{
		}

		public DbSet<Student> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlServer("");
            base.OnConfiguring(optionsBuilder);
        }

    }
}

