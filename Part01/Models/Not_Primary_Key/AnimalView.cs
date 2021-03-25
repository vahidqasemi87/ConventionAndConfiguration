using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.Not_Primary_Key
{
	//Keyless
	//[Microsoft.EntityFrameworkCore.Keyless]
	public class AnimalView
	{
		public string Name { get; set; }
		public string Color { get; set; }
	}
	public class AnimalViewFluent : IEntityTypeConfiguration<AnimalView>
	{
		public void Configure(EntityTypeBuilder<AnimalView> builder)
		{
			builder.HasNoKey().ToView("vw_AnimalView");
		}
	}
}
