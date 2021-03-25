using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.Naming
{
	[System.ComponentModel.DataAnnotations.Schema.Table("AttributeBank", Schema = "bnk")]
	public class BankInfoAtt
	{
		public int Id { get; set; }
		[System.ComponentModel.DataAnnotations.Schema.Column(name: "ShHesab", TypeName = "NVARCHAR(16)")]
		public string ShomareHesab { get; set; }
		[System.ComponentModel.DataAnnotations.Schema.Column(name: "ShShaba", TypeName = "NVARCHAR(20)")]
		public string ShomareShaba { get; set; }
	}
}
