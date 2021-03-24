using Microsoft.EntityFrameworkCore;
using Part01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.DataAccess
{
	public class ConfigContext : DbContext
	{
		public DbSet<PersonCon> PersonCons { get; set; }
		public DbSet<PersonAttribute> PersonAttributes { get; set; }
		public DbSet<PersonFluent> PersonFluents { get; set; }
		public DbSet<Student> Students { get; set; }
		public ConfigContext(DbContextOptions<ConfigContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
			modelBuilder.Ignore<PersonFluIgnone>();
			base.OnModelCreating(modelBuilder);
		}
	}
}
