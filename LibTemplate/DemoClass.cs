using JetBrains.Annotations;
using LibTemplate.Options;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;

namespace LibTemplate
{
	[UsedImplicitly]
	public class DemoClass : ITransientDependency
	{
		private readonly DemoClassOptions _option;

		public DemoClass(IOptions<DemoClassOptions> options)
		{
			_option = options.Value;
		}

		public bool IsSuccess()
		{
			return _option.IsSuccess;
		}
	}
}
