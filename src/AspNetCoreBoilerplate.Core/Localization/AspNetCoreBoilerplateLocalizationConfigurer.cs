using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AspNetCoreBoilerplate.Localization
{
    public static class AspNetCoreBoilerplateLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AspNetCoreBoilerplateConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AspNetCoreBoilerplateLocalizationConfigurer).GetAssembly(),
                        "AspNetCoreBoilerplate.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
