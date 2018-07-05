using Newtonsoft.Json;
using NiceHashMinerLegacy.Common.Configs;

namespace NiceHashMinerLegacy.Common
{
    public class Globals
    {
        // Constants
        public static string[] MiningLocation = {"eu", "usa", "hk", "jp", "in", "br"};

        public static readonly string DemoUser = "33hGFJZQAfbdzyHGqhJPvZwncDjUBdZqjW";

        // change this if TOS changes
        public const int CurrentTosVer = 4;

        // Variables
        public static JsonSerializerSettings JsonSettings = null;

        public static int ThreadsPerCpu;

        // quickfix guard for checking internet conection
        public static bool IsFirstNetworkCheckTimeout = true;

        public static int FirstNetworkCheckTimeoutTimeMs = 500;
        public static int FirstNetworkCheckTimeoutTries = 10;



        public static string GetBitcoinUser()
        {
            return BitcoinAddress.ValidateBitcoinAddress(ConfigManager.GeneralConfig.BitcoinAddress.Trim())
                ? ConfigManager.GeneralConfig.BitcoinAddress.Trim()
                : DemoUser;
        }
    }
}