using System;
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
using FHSDKPortable;

namespace App1.Windows
{
    public sealed partial class MainPage
    {
        private readonly App1.App _app;

        public MainPage()
        {
            InitializeComponent();

            _app = new App1.App();
            LoadApplication(_app);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await FHClient.Init();
            _app.ProjectReady();
        }
    }
}
