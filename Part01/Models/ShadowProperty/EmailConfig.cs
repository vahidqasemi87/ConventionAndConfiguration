using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Models.ShadowProperty
{
	public class EmailConfig : IEntityTypeConfiguration<Email>
	{
		public void Configure(EntityTypeBuilder<Email> builder)
		{
			builder.Property<int>("InsertBy");
			builder.Property<DateTime>("InsertDate");
			builder.Property<int>("UpdateBy");
			builder.Property<DateTime>("UpdatetDate");
		}
	}
}
//Shadow_property
/*
 در دیتا بیس وجود دارند 
در لایه دیتااکسس و تا زمانی که من خالص به دی بی کانتکس دسترسی دارم و چینج ترکر در اختیار من است می توانم با آنها کار کنم
 */