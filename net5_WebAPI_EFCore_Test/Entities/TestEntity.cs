using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5_WebAPI_EFCore_Test.Entities
{
	public class TestEntity
	{
		public int ID { get; set; }
		public string Text { get; set; }
		public DateTime UpdateTime { get; set; }
	}
}
