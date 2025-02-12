using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoadDataApp;
using Microsoft.EntityFrameworkCore;

namespace HrLab
{
	public class ApplicationContext: DbContext
	{
		public DbSet<Condidate> Condidates { get; set; } = null!;

		public ApplicationContext() 
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=MISHA1893208\SQLEXPRESS;Database=condidates_db;Trusted_Connection=True;TrustServerCertificate=True");
		}
	}
}
