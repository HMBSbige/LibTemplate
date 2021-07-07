using LibTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class UnitTest : TestBase
	{
		[TestMethod]
		public void Test()
		{
			var instance = LazyServiceProvider.LazyGetRequiredService<DemoClass>();
			Assert.IsTrue(instance.IsSuccess());
		}
	}
}
