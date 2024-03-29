﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Xiaomi_Svet
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            
            this.InitializeComponent();
            viewDevises = new ViewDevises();
            //viewDevises.ListDevices.Add(new DeviceM("Lampa", "192.168.13.2"));
            viewDevises.ListDevices.Add(new DeviceM("Lampa", "192.168.31.28"));
        }
        ViewDevises viewDevises { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
