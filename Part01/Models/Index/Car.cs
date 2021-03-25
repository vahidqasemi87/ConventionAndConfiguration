using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.Index
{
	public class Car
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Color { get; set; }
		public int FactoryNo { get; set; }
	}
	public class CarFluent : IEntityTypeConfiguration<Car>
	{
		public void Configure(EntityTypeBuilder<Car> builder)
		{
			builder
				.HasIndex(c => new { c.FactoryNo, c.Name });
		}
	}
}
