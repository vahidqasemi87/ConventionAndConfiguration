using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.Not_Primary_Key
{
	//Key_Less
	public class Animal
	{
		public string Name { get; set; }
		public string Color { get; set; }
	}
	public class AnimalFluent : IEntityTypeConfiguration<Animal>
	{
		public void Configure(EntityTypeBuilder<Animal> builder)
		{
			builder.HasNoKey();
		}
	}
}
