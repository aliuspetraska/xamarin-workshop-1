using RestSharp.Extensions.MonoHttp;
using Xamarin.Forms;

namespace WorkshopDemo1
{
	public partial class MapPage : ContentPage
	{
		private static string _origin = string.Empty;
		private static string _destination = string.Empty;

		public MapPage(string origin, string destination)
		{
			InitializeComponent();

			_origin = origin.Trim();
			_destination = destination.Trim();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			WebViewControl.Source = "http://vinylshop.herokuapp.com/api/showmap.php?width=" 
				+ WebViewControl.Width + "&height=" 
				+ WebViewControl.Height + "&origin=" 
				+ HttpUtility.UrlEncode(_origin) 
				+ "&destination=" + HttpUtility.UrlEncode(_destination);

			WebViewControl.IsEnabled = false;
		}
	}
}
