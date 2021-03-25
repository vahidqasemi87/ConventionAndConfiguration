using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.Backing_Filed
{
	public class Website
	{
		public int Id { get; set; }
		private string _domain;
		public string Domain
		{
			get
			{
				return _domain;
			}
			set
			{
				if (value.Contains(".ir"))
					_domain = value;
			}
		}
		private string _address_baking_filed;
		public string Address
		{
			get
			{
				return _address_baking_filed;
			}
			set
			{
				_address_baking_filed = value;
			}
		}

		//faild

		//private string _webNumber;
		//public void SetWebNumber(string webNumber)
		//{
		//	_webNumber = webNumber;
		//}
		//public string GetWebNumber()
		//{
		//	return _webNumber;
		//}
	}
	public class WebsiteConfig : IEntityTypeConfiguration<Website>
	{
		public void Configure(EntityTypeBuilder<Website> builder)
		{
			builder.Property(c => c.Address).HasField("_address_baking_filed");

			//faild
			//builder.Property<string>("WebNumber").HasField("_webNumber");
		}
	}
}
