using LibTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
	[TestClass]
	public class UnitTest : TestBase
	{
		private DemoClass Instance => LazyServiceProvider.LazyGetRequiredService<DemoClass>();

		[TestMethod]
		public void Test()
		{
			Assert.IsTrue(Instance.IsSuccess());

			var instance = LazyServiceProvider.LazyGetRequiredService<DemoClass>();
			Assert.AreSame(Instance, instance);
		}
	}
}
