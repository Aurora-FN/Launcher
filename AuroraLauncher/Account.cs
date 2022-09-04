using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AuroraLauncher
{
    class Account
    {
        // Email + Password
        public static string Email = "";
        public static string Password = "";
        public static string Path = "";

        // Variables
        public static bool bisSinglePlayer = false;
        public static bool bCustomFLToken = false; // Chapter 1 - 2
        
        // Launch Variables
        public static bool OldLaunch = false; // support for old versions patch
        public static bool NewVerSupport = false; // support for newer versions patch (fiddler required)


        // Launcher Variables
        public static string RedirectDLL = "AuroraRedirect.dll";
        public static string MultiplayerDLL = "Client.dll";
        public static string SinglePlayerDLL = "AuroraSP.dll";

        // Defaults
        public static string DefaultFLToken = "87a0c99d9aa3ab5bb6a36C25"; // idk which version this is for

        // Custom
        public static string CustomFLToken = ""; // only edited if bCustomFLToken is enabled
        
    }
}
