using Microsoft.EntityFrameworkCore;
using Part01.DataAccess;
using Part01.Models.ShadowProperty;
using System;
using System.Linq;

namespace Part01
{
	class Program
	{
		static void Main(string[] args)
		{
			//Shadow_Property01();
			Shadow_Property02();
		}

		private static void Shadow_Property02()
		{
			using (var db = ContextFactory.GetSqlContext())
			{
				var email = db.Set<Email>().FirstOrDefault();
				db.Entry(email).Property<int>("InsertBy").CurrentValue = 2;

				var listData = db.Set<Email>().OrderBy(b => EF.Property<DateTime>(b, "UpdatetDate")).ToList();
				foreach (var item in listData)
				{
					Console.WriteLine(item.Address + "_" + item.Domain);
				}
			}
		}

		private static void Shadow_Property01()
		{
			using (var db = ContextFactory.GetSqlContext())
			{
				var email = db.Set<Email>().FirstOrDefault();
				int insertValue = db.Entry(email).Property<int>("InsertBy").CurrentValue;
				Console.WriteLine($"InsertBy is : {insertValue}");
				insertValue = db.Entry(email).Property<int>("InsertBy").CurrentValue = 2;
				Console.WriteLine($"InsertBy is : {insertValue}");
			}
		}
	}
}