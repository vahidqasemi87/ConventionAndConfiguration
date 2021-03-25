using Microsoft.EntityFrameworkCore;
using Part01.Models;
using Part01.Models.Naming;
using Part01.Models.Not_Primary_Key;
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
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Animal> Animals { get; set; }
		public DbSet<AnimalView>AnimalViews { get; set; }
		public DbSet<BankInfoAtt> BankInfoAtts{ get; set; }
		public ConfigContext(DbContextOptions<ConfigContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
			modelBuilder.Ignore<PersonFluIgnone>();
			//modelBuilder.Entity<Animal>().HasNoKey();
			modelBuilder.HasDefaultSchema("config");
			//if (Database.IsSqlServer())
			//{
			//	// Config Sql Server
			//	modelBuilder.Entity<PersonFluent>().IsMemoryOptimized();
			//}
			//else
			//{

			//}
			//if (Database.IsRelational())
			//{

			//}
			//foreach (var entityType in modelBuilder.Model.GetEntityTypes())
			//{
			//	modelBuilder.Entity(entityType.ClrType).Property<int>("AutoShadow");
			//}
			base.OnModelCreating(modelBuilder);
		}
	}
}
