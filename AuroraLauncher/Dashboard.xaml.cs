using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            Username.Content = AuroraLauncher.Account.Email;
        }

        private void LaunchFNClicked(object sender, RoutedEventArgs e)
        {
            Fortnite.StartFortnite();
        }

        private void SettingsClicked(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void DiscordClicked(object sender, RoutedEventArgs e)
        {
            Process Discord = new Process();
            Discord.StartInfo.UseShellExecute = true;
            Discord.StartInfo.FileName = "https://discord.gg/bdvaDqkbK4";
            Discord.Start();
        }

        private void ChatClicked(object sender, RoutedEventArgs e)
        {
            Aurora.ChatService.ChatClient chat = new Aurora.ChatService.ChatClient();
            chat.Show();
        }
    }
}
