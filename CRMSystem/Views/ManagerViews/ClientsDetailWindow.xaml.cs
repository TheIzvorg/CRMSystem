﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CRMSystem.DataBase;

namespace CRMSystem.Views.ManagerViews
{
    public partial class ClientsDetailWindow : Window
    {
        Users _currentCustomer;
        public ClientsDetailWindow(List<OrderDetails> user)
        {
            InitializeComponent();
            _currentCustomer = user[0].Customer;
            this.DataContext = user;
            grid.ItemsSource = user;
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Image image = sender as Image;

            if (_currentCustomer.Foto == null)
                image.Source = new BitmapImage(
                    new System.Uri(@"pack://application:,,,/CRMSystem;component/Resources/Images/Placeholders/ImagePlaceholder.png"));

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
