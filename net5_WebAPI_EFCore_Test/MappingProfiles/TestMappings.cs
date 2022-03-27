using AutoMapper;
using net5_WebAPI_EFCore_Test.Dtos;
using net5_WebAPI_EFCore_Test.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5_WebAPI_EFCore_Test.MappingProfiles
{
	public class TestMappings : Profile
	{
		public TestMappings()
		{
			CreateMap<TestEntity, TestInsertDto>().ReverseMap();
		}
	}
}
