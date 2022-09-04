using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AuroraLauncher
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        public static void LoadSettings()
        {
            if(AuroraLauncher.Account.bisSinglePlayer == true) {  }
        }

        private void SinglePlayerChecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.bisSinglePlayer = true;
        }

        private void SinglePlayerUnchecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.bisSinglePlayer = false;
        }

        private void FNPathSaved(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.Path = FortnitePathText.Text;
        }

        private void OldSupportPatchChecked(object sender, RoutedEventArgs e)
        {
                AuroraLauncher.Account.OldLaunch = true;
        }

        private void SettingsLoaded(object sender, RoutedEventArgs e)
        {
            if (AuroraLauncher.Account.bisSinglePlayer == true) { SinglePlayerIngame.IsChecked = true; } // Singleplayer DLL Enabled
            if (AuroraLauncher.Account.OldLaunch == true) { OldVerSupportBox.IsChecked = true; } // Experimental Old Version support *Fiddler required*
            if (AuroraLauncher.Account.Path != "") { FortnitePathText.Text = AuroraLauncher.Account.Path; } // Fortnite Path
            if (AuroraLauncher.Account.bCustomFLToken == true) { CustomFLTokenCheckbox.IsChecked = true; } // Enable Custom FLToken (Chapter 1 and 2)
            if (AuroraLauncher.Account.CustomFLToken != "") { CustomFLTokenText.Text = AuroraLauncher.Account.CustomFLToken; } // Custom FLToken Text (shouldn't exist if Enable Custom FLToken is false)
            if (AuroraLauncher.Account.NewVerSupport == true) { NewVersionSupportBox.IsChecked = true; } // New Version support (S16+ I think)
        }

        private void CustomFLTokenChecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.bCustomFLToken = true;
            CustomFLTokenText.IsEnabled = true;
            SaveFLToken_Btn.IsEnabled = true;
        }

        private void CustomFLTokenUnchecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.bCustomFLToken = false;
            AuroraLauncher.Account.CustomFLToken = ""; // reverts to nothing
            CustomFLTokenText.IsEnabled = false;
            SaveFLToken_Btn.IsEnabled = false;
        }

        private void FLTokenSave(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.CustomFLToken = CustomFLTokenText.Text;
        }

        private void LaunchConsoleChecked(object sender, RoutedEventArgs e)
        {
        }

        private void LaunchConsoleUnchecked(object sender, RoutedEventArgs e)
        {
        }

        private void NewVerSupportChecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.NewVerSupport = true;
            MessageBox.Show(AuroraLauncher.Account.NewVerSupport.ToString());
        }

        private void NewVerSupportUnchecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.NewVerSupport = false;
            MessageBox.Show(AuroraLauncher.Account.NewVerSupport.ToString());
        }

        private void OldSupportUnchecked(object sender, RoutedEventArgs e)
        {
            AuroraLauncher.Account.OldLaunch = false;
        }
    }
}
