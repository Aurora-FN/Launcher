using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AuroraLauncher
{
    class Fortnite
    {

        public static void StartFortnite()
        {
            var GamePath = AuroraLauncher.Account.Path;
            var Email = AuroraLauncher.Account.Email;
            var Password = AuroraLauncher.Account.Password;

            if (AuroraLauncher.Account.OldLaunch == true)
            {
                if (MessageBox.Show("You have enabled the experimental option 'Old version support'\nThis allows versions BELOW S2 to be launched without crashing the game and/or launcher\n\nYou have to use Fiddler to use this because redirect dll is not an option.\n\nProceed?", "Aurora Notice", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    // return
                } else
                {
                    Process process2 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                    Process process3 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + AuroraLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + AuroraLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                    process3.WaitForInputIdle();
                    // No dll because I don't have 1.7.2 curl sigs
                    process3.WaitForExit();
                    process2.Close();
                    process3.Close();
                    AuroraLauncher.Account.OldLaunch = false;
                }
                    
            }
            else if (AuroraLauncher.Account.bCustomFLToken == true)
            {
                if (MessageBox.Show("You have enabled CustomFLToken\nThis allows versions that this launcher does not support to be supported!\nFLToken you put in: " + AuroraLauncher.Account.CustomFLToken + "\nSome versions will need fiddler.\n\nProceed?", "Aurora Notice", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    // return
                } else
                {
                    Process process = ProcessHelper.StartCustomProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
                    Process process2 = ProcessHelper.StartCustomProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                    Process process4 = ProcessHelper.StartCustomProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
                    Process process3 = ProcessHelper.StartCustomProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + AuroraLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + AuroraLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                    process3.WaitForInputIdle();
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AuroraLatestRedirect.dll"));
                    process3.WaitForExit();
                    process.Close();
                    process2.Close();
                    process3.Close();
                    process4.Close();
                }
            }
            else if(AuroraLauncher.Account.NewVerSupport == true)
            {
                if(MessageBox.Show("You have enabled the experimental option 'New version support'\nThis allows versions ABOVE S17 to be launched without crashing\n\nYou have to use Fiddler to use this because redirect dll is not an option.\n\nProceed?", "Aurora Notice", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    // Nothing
                }
                else
                {
                    Process process = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
                    Process process2 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                    Process process4 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
                    Process process3 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + AuroraLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + AuroraLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                    process3.WaitForInputIdle();
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AuroraLatestRedirect.dll"));
                    process3.WaitForExit();
                    process.Close();
                    process2.Close();
                    process3.Close();
                    process4.Close();
                }
            }
            else
            {
                Process process = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "");
                Process process2 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
                Process process4 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe", true, "");
                Process process3 = ProcessHelper.StartProcess(AuroraLauncher.Account.Path + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, "-AUTH_TYPE=epic -AUTH_LOGIN=\"" + AuroraLauncher.Account.Email + "\" -AUTH_PASSWORD=\"" + AuroraLauncher.Account.Password + "\" -SKIPPATCHCHECK");
                process3.WaitForInputIdle();
                ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), AuroraLauncher.Account.RedirectDLL));
                if (AuroraLauncher.Account.bisSinglePlayer == true)
                {
                    MessageBox.Show("Press OK to Inject Singleplayer", "Aurora Popup");
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), AuroraLauncher.Account.SinglePlayerDLL));
                }
                else
                {
                    MessageBox.Show("Press OK to Inject Multiplayer", "Aurora Popup");
                    ProcessHelper.InjectDll(process3.Id, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), AuroraLauncher.Account.MultiplayerDLL));
                }
                process3.WaitForExit();
                process.Close();
                process2.Close();
                process3.Close();
                process4.Close();
            }
        }
    }
}
