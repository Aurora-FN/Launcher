using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuroraLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Login properly
            AuroraLauncher.Account.Email = Email.Text;
            AuroraLauncher.Account.Password = Password.Text;

            Window1 window = new Window1(); // dashboard
            window.Show();
            this.Close();
        }

        private void InfoClicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aurora was created by Slushia, Cyuubi, Jake, and Cyclonefreeze\n\nAurora v3 was created by EnderDev#1337.\nWe have permission from a Aurora Developer to use the name Aurora.", "Aurora Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
