using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.DataAccess
{
	public static class ContextFactory
	{
		public static ConfigContext GetSqlContext()
		{
			var builder = new DbContextOptionsBuilder<ConfigContext>();
			builder.UseSqlServer("server=.;database=ConfigDb;uid=test;pwd=sqlserver2017!@#$%;");
			return new ConfigContext(builder.Options);
		}
	}
}
