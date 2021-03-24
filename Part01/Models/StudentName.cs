using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models
{
	public class StudentName
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
	public class Student
	{
		public int Id { get; set; }
		public string FullName { get; set; }
		public StudentName Name { get; set; }
		public string EncryctionText { get; set; }
	}
	public class PersonConfig : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.Property(c => c.Name).HasConversion(
				x => Newtonsoft.Json.JsonConvert.SerializeObject(x),
				y => Newtonsoft.Json.JsonConvert.DeserializeObject<StudentName>(y)
				);

			builder.Property(c => c.EncryctionText).HasConversion(new EncryptedConverter());
		}
	}
	//value convertor Ekhtesasi ... 
	public class EncryptedConverter : Microsoft.EntityFrameworkCore.Storage.ValueConversion.ValueConverter<string, string>
	{
		public EncryptedConverter(ConverterMappingHints mappingHints = default)
			: base(EncryptExpr, DecryptExpr, mappingHints)
		{ }

		static Expression<Func<string, string>> DecryptExpr = x => new string(x.Reverse().ToArray());
		static Expression<Func<string, string>> EncryptExpr = x => new string(x.Reverse().ToArray());
	}
	//enums
	public enum WeekDay
	{
		Sat,Sun,Mon,Tue,Wen,Thu,Fri
	}
}
