﻿using BoundlessProxyUi.ProxyManager.Components;
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

namespace BoundlessProxyUi.ProxyManager
{
    /// <summary>
    /// Interaction logic for CheckCert.xaml
    /// </summary>
    public partial class CheckCert : UserControl
    {
        public CheckCert(string message)
        {
            InitializeComponent();

            txtMessage.Text = message;
        }

        private void BtnContinue_Click(object sender, RoutedEventArgs e)
        {
            ((ManagerWindowViewModel)ProxyManagerWindow.Instance.DataContext).UserAuthorizedCert = true;

            btnContinue.IsEnabled = false;
            ComponentEngine.Instance.Start();
        }
    }
}
