﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Logger.Info("Starting DCTools.");
        }

        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        User.Local lUser = new User.Local();

        private void btnOK_Click(object sender, RoutedEventArgs e) {
            Logger.Debug("OK Button Clicked.");
            lUser.Add("Chris", User.Local.Environment.CUCBECM);
        }
    }
}
