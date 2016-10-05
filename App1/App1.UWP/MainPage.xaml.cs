using Windows.UI.Xaml.Navigation;
using FHSDKPortable;

namespace App1.UWP
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