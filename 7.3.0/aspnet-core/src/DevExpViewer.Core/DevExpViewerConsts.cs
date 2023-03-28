using DevExpViewer.Debugging;

namespace DevExpViewer
{
    public class DevExpViewerConsts
    {
        public const string LocalizationSourceName = "DevExpViewer";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "24ca5439c2da441d94f930a372719e38";
    }
}
