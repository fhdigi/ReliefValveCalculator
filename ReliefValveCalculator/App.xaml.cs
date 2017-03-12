using Xamarin.Forms;

namespace ReliefValveCalculator
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// call the main page
			MainPage = new NavigationPage(new ReliefValvePage());
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
