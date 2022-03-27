using net5_WebAPI_EFCore_Test.DB;
using net5_WebAPI_EFCore_Test.Dtos;
using net5_WebAPI_EFCore_Test.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5_WebAPI_EFCore_Test.Repositories
{
	public class TestSqlRepository : ITestSqlRepository
	{
		private readonly TestDBContext _testDBContext;

		public TestSqlRepository(TestDBContext testDBContext)
		{
			_testDBContext = testDBContext;
		}

		public async Task<TestEntity> GetFirst()
		{
			return _testDBContext.TB_Test.FirstOrDefault();
		}
		public async Task<IQueryable<TestEntity>> GetAll()
		{
			return _testDBContext.TB_Test.Select(x => x);
		}
		public async Task Add(TestEntity testEntity)
		{
			await _testDBContext.TB_Test.AddAsync(testEntity);
		}
		public async Task<bool> Save()
		{
			return (await _testDBContext.SaveChangesAsync()) >= 0;
		}

	}
}
