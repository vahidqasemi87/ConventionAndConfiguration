using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Part01.Models
{
	public class PersonAttribute
	{
		public int Id { get; set; }
		[Required]
		[Column("FName",TypeName = "VARCHAR(50)")]
		public string FirstName { get; set; }
		[Column("LName",TypeName = "NVARCHAR(5)")]
		public string LastName { get; set; }
		[NotMapped]
		public string FullName
		{
			get
			{
				return $"{FirstName} , {LastName}";
			}
			//set { }
		}
		public int Age { get; set; }
		[Column(TypeName = "DATETIME2")]
		public DateTime BirthDate { get; set; }
		public List<PersonAttNotMapped> PersonAttNotMappeds { get; set; }
	}
	[System.ComponentModel.DataAnnotations.Schema.NotMapped]
	public class PersonAttNotMapped
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}
