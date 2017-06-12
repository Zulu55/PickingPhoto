using Xamarin.Forms;

namespace PickingPhoto
{
    public partial class App : Application
    {
		// https://developer.xamarin.com/guides/xamarin-forms/application-fundamentals/dependency-service/photo-picker/
		public App()
        {
            InitializeComponent();

            MainPage = new PickingPhotoPage();
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
