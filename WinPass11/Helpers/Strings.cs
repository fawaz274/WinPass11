﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPass11.Helpers
{
    class Strings
    {
        public class Titles
        {
            private static readonly string Prefix       = "WinPass11";
            public  static readonly string Information  = $"{Prefix} Information";
            public  static readonly string Error        = $"{Prefix} Error";
        }

        public class Body
        {
            public static readonly string DeleteFailed           = "Failed to delete {0}.";

            public static readonly string DownloadFailed         = "Failed to download {0}. Check your internet connection and try again.";
            public static readonly string DownloadSuccess        = "Successfully downloaded {0}.";

            public static readonly string FileNotDownloaded      = "Windows Update hasn't downloaded {0}.";

            public static readonly string InstallButtonDialog    = "Are you sure you want to do this? You cannot undo this action.";
            public static readonly string InstallationCanceled   = "Installation canceled.";

            public static readonly string InvalidChannel         = "Invalid channel. Please select a valid channel.";

            public static readonly string RegApplyFailed         = "Failed to apply registry tweaks.";
            public static readonly string RegApplySuccess        = "Successfully applied registry tweaks.";
            public static readonly string RegFileNotDownloaded   = "Failed to apply non-existant file.";

            public static readonly string ReplaceSuccess         = "Successfully replaced {0}.";
            public static readonly string ReplaceFailed          = "Failed to replace {0}.";

            public static readonly string SetupDownloaded        = "Windows Update downloaded {0}.";

            public static readonly string WaitingForDownload     = "Waiting for Windows Update to download {0}.";
        }
    }
}
