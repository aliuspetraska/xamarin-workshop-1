using System;
using Xamarin.Forms;

namespace WorkshopDemo1
{
	public partial class IntroPage : ContentPage
	{
		public IntroPage()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchPage());
		}
	}
}
