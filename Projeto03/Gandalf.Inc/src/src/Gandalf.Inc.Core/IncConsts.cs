using Gandalf.Inc.Debugging;

namespace Gandalf.Inc
{
    public class IncConsts
    {
        public const string LocalizationSourceName = "Inc";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "aa72ee48003d4c6a9ad783df5afcc1d3";
    }
}
