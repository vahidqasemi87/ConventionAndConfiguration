using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.DataAccess
{
	public class ConfigContextFactory : IDesignTimeDbContextFactory<ConfigContext>
	{
		public ConfigContext CreateDbContext(string[] args)
		{
			return ContextFactory.GetSqlContext();
		}
	}
}
