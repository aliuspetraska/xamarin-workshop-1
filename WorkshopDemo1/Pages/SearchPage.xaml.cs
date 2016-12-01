using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Newtonsoft.Json;
using Plugin.Geolocator;
using RestSharp;
using Xamarin.Forms;

namespace WorkshopDemo1
{
	public partial class SearchPage : ContentPage
	{
		public static ObservableCollection<Store> _ObservableCollection = new ObservableCollection<Store>();

		public SearchPage()
		{
			InitializeComponent();

			ListViewControl.ItemsSource = _ObservableCollection;

			SearchBarControl.SearchCommand = new Command(() =>
			{
				if (SearchBarControl.Text.Trim().Length > 0)
				{
					FindRecordShops(SearchBarControl.Text.Trim());
				}
			});

			SearchBarControl.TextChanged += (object sender, TextChangedEventArgs e) =>
			{
				if (string.IsNullOrEmpty(SearchBarControl.Text))
				{
					_ObservableCollection.Clear();

					Device.BeginInvokeOnMainThread(() =>
					{
						ListViewControl.IsVisible = false;
					});
				}
			};
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			try
			{
				var locator = CrossGeolocator.Current;
				locator.DesiredAccuracy = 2000; // 1km

				if (locator.IsGeolocationEnabled)
				{
					var position = await locator.GetPositionAsync(60000);

					var client = new RestClient("http://vinylshop.herokuapp.com/api/");
					var request = new RestRequest("getaddress.php", Method.GET);

					request.AddParameter("lat", position.Latitude);
					request.AddParameter("lon", position.Longitude);

					client.ExecuteAsync(request, response =>
					{
						try
						{
							var data = JsonConvert.DeserializeObject<AdressObject>(response.Content);

							if (data.error == false)
							{
								if (string.IsNullOrEmpty(SearchBarControl.Text))
								{
									Device.BeginInvokeOnMainThread(() =>
									{
										SearchBarControl.Text = data.formatted_address;
									});

									FindRecordShops(data.formatted_address);
								}
							}
						}
						catch (Exception ex)
						{
							Debug.WriteLine(ex.Message);
						}
					});
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		void FindRecordShops(string city)
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				ActivityIndicatorControl.IsVisible = true;
			});

			var client = new RestClient("http://vinylshop.herokuapp.com/api/");
			var request = new RestRequest("getstores.php", Method.GET);

			request.AddParameter("query", HttpUtility.UrlEncode(city));

			client.ExecuteAsync(request, response =>
			{
				try
				{
					var data = JsonConvert.DeserializeObject<StoresObject>(response.Content);

					if (data.error == false)
					{
						_ObservableCollection.Clear();

						foreach (var item in data.stores)
						{
							_ObservableCollection.Add(item);
						}

						Device.BeginInvokeOnMainThread(() =>
						{
							ListViewControl.IsVisible = true;

							ActivityIndicatorControl.IsVisible = false;
						});
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
			});
		}

		async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			ListViewControl.SelectedItem = -1;

			var item = e.Item as Store;

			Debug.WriteLine(item.name);

			await Navigation.PushAsync(new MapPage(SearchBarControl.Text, item.formatted_address)
			{
				Title = item.name
			});
		}
	}
}
