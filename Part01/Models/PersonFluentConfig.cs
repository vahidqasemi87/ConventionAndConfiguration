using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace Part01.Models
{
	public class PersonFluentConfig : Microsoft.EntityFrameworkCore.IEntityTypeConfiguration<PersonFluent>
	{
		public void Configure(EntityTypeBuilder<PersonFluent> builder)
		{
			builder.Property(c => c.FirstName)
				.HasMaxLength(50)
				.IsRequired()
				.IsUnicode()
				.HasColumnName("FName")
				.HasColumnType("VARCHAR(55)");
			builder.Property(c => c.BirthDate)
				.HasColumnType("DateTime");
			builder.Property(c => c.LastName)
				.IsRequired()
				.IsUnicode()
				.HasColumnType("NVARCHAR(46)")
				.HasColumnName("LName");
			builder.Property(c => c.Age).HasPrecision(10, 4);
			//Value Conversions
			builder.Property(c => c.PersonType).HasConversion<string>().HasColumnType("NVARCHAR(20)").HasColumnName("PType");

			var valueConvertor =
				new Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<NationalCode, string>
				(nationalCode => nationalCode.Value, str => new NationalCode(str));

			builder.Property(c => c.NationalCode).HasConversion(valueConvertor).HasColumnName("NCode").HasColumnType("NVARCHAR(10)");
			//
			builder.Ignore(c => c.FullName);
		}
	}
}
