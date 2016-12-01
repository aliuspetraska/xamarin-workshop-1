using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace WorkshopDemo1
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = new NavigationPage(new IntroPage())
			{
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex("#FB7A52")
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
