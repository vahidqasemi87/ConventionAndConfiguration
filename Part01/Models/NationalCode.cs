using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models
{
	public class NationalCode : object
	{
		public string Value { get; private set; }
		public NationalCode(string nationalCode) : base()
		{
			//checking SNN
			Value = nationalCode;
		}
	}
}
