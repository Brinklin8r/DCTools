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

namespace DCTools.UI {
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    /// 
    public partial class LoginWindow : Window {
        public LoginWindow() {
            InitializeComponent();
            Logger.Info("Login Called.");
        }

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private void btnLogin_Click(object sender, RoutedEventArgs e) {
            Logger.Debug("Login Button Clicked.");

            if (tbUN.Text != "" && tbPW.Password != "") {
                Logger.Debug("Got a User Name and Password.");
                this.Close();
            } else {
                Logger.Error("You did not enter a User Name or Password.");
                lblResults.Content = "You did not enter a User Name or Password.";
            }
        }
    }
}
