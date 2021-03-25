using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Part01.Models
{
	public class Teacher
	{
		[Key]
		public int My_Primary_Id { get; set; }
		[MaxLength(50)]
		[Column("FName", TypeName = "NVARCHAR(51)")]
		public string FirstName { get; set; }
		[Column("LName", TypeName = "NVARCHAR(51)")]
		[MaxLength(50)]
		public string LastName { get; set; }
		[NotMapped]
		public string FullName { get; set; }
		public int Age { get; set; }
		[Column(TypeName = "Datetime")]
		public DateTime BirthDate { get; set; }
	}
}
