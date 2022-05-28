﻿using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CRMSystem.Views.ManagerViews
{
    public partial class ManagerWindow : Window
    {
        public Users CurrentManager { get; private set; }
        public DateTime StartupTime { get; private set; }
        public ManagerWindow(Users manager)
        {
            InitializeComponent();
            StartupTime = DateTime.Now;
            CurrentManager = manager;
            ManagerFoto.DataContext = CurrentManager;
            if (manager?.Foto == null)
                ManagerFoto.Source = new BitmapImage(
                    new Uri(@"pack://application:,,,/CRMSystem;component/IMG/unknownImage.png"));
            MainFrame.Navigate(new PersonalAccountFrame(this,CurrentManager));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersFrame(CurrentManager));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsFrame(CurrentManager));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StorageFrame());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PersonalAccountFrame(this,CurrentManager));
        }
    }
}
