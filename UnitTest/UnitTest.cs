namespace UnitTest;

[TestClass]
public class UnitTest : TestBase
{
	private DemoClass Instance => LazyServiceProvider.LazyGetRequiredService<DemoClass>();

	[TestMethod]
	public void Test()
	{
		Assert.IsTrue(Instance.IsSuccess());

		DemoClass instance = LazyServiceProvider.LazyGetRequiredService<DemoClass>();
		Assert.AreSame(Instance, instance);
	}
}
