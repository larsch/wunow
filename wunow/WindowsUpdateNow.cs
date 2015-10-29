using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Management;
using System.ComponentModel;
using Mono.Options;
#if false
using WUApiLib;
#endif

namespace wunow
{
    class WindowsUpdateNow
    {
        static bool showHelp = false;
        static bool rebootIfNeeded = true;
        static bool listUpdates = false;
        static string query = "IsInstalled=0 and Type='Software'";

#if false
        static bool InstallUpdates_WUApiLib()
        {
            UpdateSession updateSession = new UpdateSession(); //  Activator.CreateInstance(updateSessionType);
            IUpdateSearcher updateSearcher = updateSession.CreateUpdateSearcher();
            Console.WriteLine("Searching for available updates...");
            ISearchResult searchResult;
            try
            {
                searchResult = updateSearcher.Search(query);
            }
            catch (COMException e)
            {
                Console.WriteLine(WUError.GetHRMessage(e.HResult));
                return false;
            }

            UpdateCollection updatesToInstall = new UpdateCollection();
            for (int i = 0; i < searchResult.Updates.Count; ++i)
            {
                IUpdate update = searchResult.Updates[i];
                Console.WriteLine(update.Title);
                updatesToInstall.Add(update);
            }

            if (searchResult.Updates.Count == 0)
            {
                Console.WriteLine("No updates found.");
                return false;
            }

            if (listUpdates)
            {
                return false;
            }

            if (updatesToInstall.Count > 0)
            {
                IUpdateInstaller installer = updateSession.CreateUpdateInstaller();
                installer.Updates = updatesToInstall;
                IInstallationResult installResult;
                try
                {
                    installResult = installer.Install();
                }
                catch (COMException e)
                {
                    Console.WriteLine(WUError.GetHRMessage(e.HResult));
                    return false;
                }
                Console.WriteLine("Installation result code: " + installResult.ResultCode);
                Console.WriteLine("Reboot required: " + installResult.RebootRequired);
                return installResult.RebootRequired;
            }

            return false;
        }
#endif
        static bool InstallUpdates()
        {
            Type updateSessionType = Type.GetTypeFromProgID("Microsoft.Update.Session");
            dynamic updateSession = Activator.CreateInstance(updateSessionType);
            dynamic updateSearcher = updateSession.CreateUpdateSearcher();
            Console.WriteLine("Searching for available updates...");
            dynamic searchResult;
            try
            {
                searchResult = updateSearcher.Search(query);
            }
            catch (COMException e)
            {
                Console.WriteLine(WUError.GetHRMessage(e.HResult));
                return false;
            }

            Type updateCollectionType = Type.GetTypeFromProgID("Microsoft.Update.UpdateColl");
            dynamic updatesToInstall = Activator.CreateInstance(updateCollectionType);
            for (int i = 0; i < searchResult.Updates.Count; ++i)
            {
                dynamic update = searchResult.Updates[i];
                Console.WriteLine(update.Title);
                updatesToInstall.Add(update);
            }

            if (searchResult.Updates.Count == 0)
            {
                Console.WriteLine("No updates found.");
                return false;
            }

            if (listUpdates)
            {
                return false;
            }

            if (updatesToInstall.Count > 0)
            {
                dynamic installer = updateSession.CreateUpdateInstaller();
                installer.Updates = updatesToInstall;
                dynamic installResult;
                try
                {
                    installResult = installer.Install();
                }
                catch (COMException e)
                {
                    Console.WriteLine(WUError.GetHRMessage(e.HResult));
                    return false;
                }
                Console.WriteLine("Installation result code: " + installResult.ResultCode);
                Console.WriteLine("Reboot required: " + installResult.RebootRequired);
                return installResult.RebootRequired;
            }

            return false;
        }


        static void Main(string[] args)
        {
            var p = new OptionSet()
            {
                { "q|query=", "specify the update search query", (string v) => query = v },
                { "n|no-reboot", "do not reboot after installation", v => rebootIfNeeded = (v == null) },
                { "l|list", "list updates only", v => listUpdates = (v != null) },
                { "?|h|help", "show this message and exit", v => showHelp = v != null }
            };


            try
            {
                List<string> extra = p.Parse(args);
                if (extra.Count > 0)
                {
                    Console.WriteLine("Unexpected argument `" + extra.First() + "'.");
                    Console.WriteLine("Try `updatecon --help' for more information.");
                    return;
                }
            }
            catch (OptionException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Try `updatecon --help' for more information.");
                return;
            }

            if (showHelp)
            {
                Console.WriteLine("Options:");
                p.WriteOptionDescriptions(Console.Out);
                return;
            }

            bool rebootRequired = InstallUpdates();

            if (rebootRequired && rebootIfNeeded)
            {
                ManagementClass W32_OS = new ManagementClass("Win32_OperatingSystem");
                ManagementBaseObject inParams, outParams;
                int result;
                W32_OS.Scope.Options.EnablePrivileges = true;

                foreach (ManagementObject obj in W32_OS.GetInstances())
                {
                    inParams = obj.GetMethodParameters("Win32Shutdown");
                    inParams["Flags"] = 6; //ForcedReboot; -- fixed to restart rather than shutdown
                    inParams["Reserved"] = 0;

                    outParams = obj.InvokeMethod("Win32Shutdown", inParams, null);
                    result = Convert.ToInt32(outParams["returnValue"]);
                    if (result != 0) throw new Win32Exception(result);
                }
            }
        }
    }
}
