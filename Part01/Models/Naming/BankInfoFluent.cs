using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.Naming
{
	public class BankInfoFluent
	{
		public int Id { get; set; }
		public string ShomareHesab { get; set; }
		public string ShomareShaba { get; set; }
	}
	public class BankInfoFluentConfig : IEntityTypeConfiguration<BankInfoFluent>
	{
		public void Configure(EntityTypeBuilder<BankInfoFluent> builder)
		{
			builder.ToTable("FluentBank", "bnk");
			builder.Property(c => c.ShomareHesab).HasColumnName(name: "ShHesab").HasColumnType(typeName: "NVARCHAR(16)");
			builder.Property(c => c.ShomareShaba).HasColumnName(name: "ShShaba").HasColumnType(typeName: "NVARCHAR(20)");
		}
	}
}
