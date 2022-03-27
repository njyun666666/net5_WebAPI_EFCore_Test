using Microsoft.EntityFrameworkCore;
using net5_WebAPI_EFCore_Test.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5_WebAPI_EFCore_Test.DB
{
	public class TestDBContext : DbContext
	{
		public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
		{

		}
		public DbSet<TestEntity> TB_Test { get; set; }
	}
}
