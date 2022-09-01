using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class TripCalculator : Page
	{
		/*private DateTime dateHired;
		private double strKm;
		private double endKm;*/
		private int dayHired;
		private decimal pricePerDay;
		private decimal total;

		public TripCalculator()
		{
			this.InitializeComponent();
		}



		private void sysDateButton_Click(object sender, RoutedEventArgs e)
		{
			dateHirePicker.SelectedDate = DateTime.Today;
		}

		private async void calcButton_Click(object sender, RoutedEventArgs e)
		{
		/*	try
			{
				strKm = double.Parse(strKmBox.Text);
			}
			catch (Exception)
			{
				var dialogMessage = new MessageDialog("Please Enter a Number");
				await dialogMessage.ShowAsync();
				strKmBox.Focus(FocusState.Programmatic);
				strKmBox.SelectAll();
				return;
			}

			try
			{
				endKm = double.Parse(endKmBox.Text);
			}
			catch (Exception)
			{
				var dialogMessage = new MessageDialog("Please Enter a Number");
				await dialogMessage.ShowAsync();
				endKmBox.Focus(FocusState.Programmatic);
				endKmBox.SelectAll();
				return;
			}
		*/
			try
			{
				dayHired = int.Parse(noDayHiredBox.Text);
			}
			catch (Exception)
			{
				var dialogMessage = new MessageDialog("Please Enter a Number");
				await dialogMessage.ShowAsync();
				noDayHiredBox.Focus(FocusState.Programmatic);
				noDayHiredBox.SelectAll();
				return;
			}
			try
			{
				pricePerDay = decimal.Parse(priceDayBox.Text);
			}
			catch (Exception)
			{
				var dialogMessage = new MessageDialog("Please Enter a Number");
				await dialogMessage.ShowAsync();
				priceDayBox.Focus(FocusState.Programmatic);
				priceDayBox.SelectAll();
				return;
			}

			total = pricePerDay * dayHired;
			amountPayBox.Text = total.ToString();

		}

		private void exitButtom_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenu));
		}

		
	}
}
