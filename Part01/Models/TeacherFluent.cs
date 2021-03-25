using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models
{
	public class TeacherFluent
	{
		public int My_Primary_Key01 { get; set; }
		public int My_Primary_Key02 { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public DateTime BirthDate { get; set; }
	}
	public class TeacherFluentConfig : IEntityTypeConfiguration<TeacherFluent>
	{
		public void Configure(EntityTypeBuilder<TeacherFluent> builder)
		{
			builder.Property(c => c.FirstName)
				.HasMaxLength(50)
				.IsRequired(true)
				.IsUnicode(true)
				.HasColumnName("FName")
				.HasColumnType("VARCHAR(51)");

			builder.Property(c => c.LastName)
				.IsRequired(false)
				.IsUnicode(false)
				.HasColumnName("LName")
				.HasColumnType("NVARCHAR(51)")
				.HasMaxLength(50);
			builder.HasKey(c => new { c.My_Primary_Key01, c.My_Primary_Key02 });
		}
	}
}
