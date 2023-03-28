using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace DevExpViewer.Localization
{
    public static class DevExpViewerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(DevExpViewerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(DevExpViewerLocalizationConfigurer).GetAssembly(),
                        "DevExpViewer.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
