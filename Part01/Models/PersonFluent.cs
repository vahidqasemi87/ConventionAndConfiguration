using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models
{
	public enum PersonType 
	{
		Parent,Child,Student,
	}
	public class PersonFluent
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName
		{
			get
			{
				return $"{FirstName} , {LastName}";
			}
			//set { }
		}
		public int Age { get; set; }
		public DateTime BirthDate { get; set; }
		public PersonType PersonType { get; set; }
		public NationalCode NationalCode { get; set; }
		public List<PersonFluIgnone> PersonFluIgnones { get; set; }
	}
	public class PersonFluIgnone
	{
		public string FirstName { get; set; }
	}
}
