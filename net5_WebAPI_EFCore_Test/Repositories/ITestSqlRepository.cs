using net5_WebAPI_EFCore_Test.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5_WebAPI_EFCore_Test.Repositories
{
	public interface ITestSqlRepository
	{
		public Task<TestEntity> GetFirst();
		public Task<IQueryable<TestEntity>> GetAll();
		public Task Add(TestEntity testEntity);
		public Task<bool> Save();
	}
}
