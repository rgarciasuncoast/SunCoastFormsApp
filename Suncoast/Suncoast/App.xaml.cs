using Xamarin.Forms;

namespace Suncoast
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage(new ContactUspage() ) 
            {
                BarBackgroundColor = Color.FromHex("#6ABBF5")
            };
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
