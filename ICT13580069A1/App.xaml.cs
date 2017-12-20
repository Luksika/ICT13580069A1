using Xamarin.Forms;

namespace ICT13580069A1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var np = new NavigationPage(new NavPage1());
            var tp = new TabbedPage();
            tp.Children.Add(new TabPage1());
            tp.Children.Add(new TabPage2());
            tp.Children.Add(new TabPage3());

            var cp = new CarouselPage();
            cp.Children.Add(new TabPage1());
            cp.Children.Add(new TabPage2());
            cp.Children.Add(new TabPage3());

            var mp = new MasterDetailPage();
            mp.Master = new MasterDetailPage();
            mp.Detail = new NavigationPage(new ICT13580069A1Page());
            MainPage = mp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
