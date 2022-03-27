using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net5_WebAPI_EFCore_Test.Dtos;
using net5_WebAPI_EFCore_Test.Entities;
using net5_WebAPI_EFCore_Test.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5_WebAPI_EFCore_Test.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class TestController : ControllerBase
	{
		private readonly ITestSqlRepository _testSqlRepository;
		private readonly IMapper _mapper;
		public TestController(ITestSqlRepository testSqlRepository, IMapper mapper)
		{
			_testSqlRepository = testSqlRepository;
			_mapper = mapper;
		}

		public async Task<IActionResult> GetFirst()
		{
			return Ok(_testSqlRepository.GetFirst());
		}
		public async Task<IActionResult> GetAll()
		{
			return Ok(_testSqlRepository.GetAll());
		}
		[HttpPost]
		public async Task<IActionResult> Add(TestInsertDto testInsertDto)
		{
			TestEntity testEntity = _mapper.Map<TestEntity>(testInsertDto);
			await _testSqlRepository.Add(testEntity);
			await _testSqlRepository.Save();
			return Ok();
		}
	}
}
