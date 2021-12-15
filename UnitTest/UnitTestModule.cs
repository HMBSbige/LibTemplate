global using JetBrains.Annotations;
global using LibTemplate;
global using LibTemplate.Options;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
global using Volo.Abp.DependencyInjection;
global using Volo.Abp.Modularity;
global using Volo.Abp.Testing;

namespace UnitTest;

[DependsOn(typeof(LibTemplateModule))]
[UsedImplicitly]
public class UnitTestModule : AbpModule
{
	public override void ConfigureServices(ServiceConfigurationContext context)
	{
		Configure<DemoClassOptions>(option => option.IsSuccess = true);
	}
}
