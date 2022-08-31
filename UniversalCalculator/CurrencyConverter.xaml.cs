using System;
using System.Windows;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyConverter : Page
	{
		public CurrencyConverter()
		{
			this.InitializeComponent();


		}



		// Currency Calculator CLick button routine
		private void Button_Click(object sender, RoutedEventArgs e)
		{

			if (combofrom.SelectedItem == null || comboto.SelectedItem == null || input.Text.Equals(""))
			{
				outputFrom.Text = "Please fill out all parts of form";
			}
			//convert from USD to USD
			if (combofrom.SelectedIndex == 0 && comboto.SelectedIndex == 0 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1;
					outputFrom.Text = result + " US Dollars =";
					outputTo.Text = "$" + convert.ToString("0.00") + " US Dollars";
					conversion1.Text = "1 USD = 1 USD";
					conversion2.Text = "1 USD = 1 USD";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from USD to EURO
			else if (combofrom.SelectedIndex == 0 && comboto.SelectedIndex == 1 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 0.85189982;
					outputFrom.Text = result + " US Dollars =";
					outputTo.Text = "€" + convert.ToString("0.00") + " Euros";
					conversion1.Text = "1 USD = 0.85189982 Euros";
					conversion2.Text = "1 Euro = 1.1739732 USD";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from USD to Britsih Pound
			else if (combofrom.SelectedIndex == 0 && comboto.SelectedIndex == 2)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 0.72872436;
					outputFrom.Text = result + " US Dollars =";
					outputTo.Text = "£" + convert.ToString("0.00") + " British Pounds";
					conversion1.Text = "1 USD = 0.72872436 British Pounds";
					conversion2.Text = "1 British Pound = 1.371907 USD";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			//convert from USD to Rupee
			else if (combofrom.SelectedIndex == 0 && comboto.SelectedIndex == 3)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 74.257327;
					outputFrom.Text = result + " US Dollars =";
					outputTo.Text = "₹" + convert.ToString("0.00") + " Indian Rupee";
					conversion1.Text = "1 USD = 74.257327 Indian Rupee";
					conversion2.Text = "1 Indian Rupee = 0.011492628 USD";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			///////////////////////////////////////////////////////////////////////////////////////////////
			//convert from EURO to EURO
			if (combofrom.SelectedIndex == 1 && comboto.SelectedIndex == 1 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1;
					outputFrom.Text = result + " Euros =";
					outputTo.Text = "€" + convert.ToString("0.00") + " Euros";
					conversion1.Text = "1 Euro = 1 Euro";
					conversion2.Text = "1 Euro = 1 Euro";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from Euros to usd
			else if (combofrom.SelectedIndex == 1 && comboto.SelectedIndex == 0 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1.1739732;
					outputFrom.Text = result + " Euros =";
					outputTo.Text = "$" + convert.ToString("0.00") + " Us Dollars";
					conversion1.Text = "1 Euro = 1.1739732 USD";
					conversion2.Text = "1 USD = 0.85189982 Euros";

					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from Euros to Britsih Pound
			else if (combofrom.SelectedIndex == 1 && comboto.SelectedIndex == 2)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 0.8556672;
					outputFrom.Text = result + " Euros =";
					outputTo.Text = "£" + convert.ToString("0.00") + " British Pounds";
					conversion1.Text = "1 Euro = 0.8556672 British Pounds";
					conversion2.Text = "1 British Pound = 1.1686692 Euros";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			//convert from Euros to Rupee
			else if (combofrom.SelectedIndex == 1 && comboto.SelectedIndex == 3)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 87.00755;
					outputFrom.Text = result + " Euros =";
					outputTo.Text = "₹" + convert.ToString("0.00") + " Indian Rupee";
					conversion1.Text = "1 Euro = 87.00755 Indian Rupee";
					conversion2.Text = "1 Indian Rupee = 0.013492774 Euros";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			///////////////////////////////////////////////////////////////////////////////////////////////
			//convert from British to British
			if (combofrom.SelectedIndex == 2 && comboto.SelectedIndex == 2 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1;
					outputFrom.Text = result + " British Pounds =";
					outputTo.Text = "£" + convert.ToString("0.00") + " British Pounds";
					conversion1.Text = "1 British Pound = 1 British Pound";
					conversion2.Text = "1 British Pound = 1 British Pound";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from British to USD
			else if (combofrom.SelectedIndex == 2 && comboto.SelectedIndex == 0 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1.371907;
					outputFrom.Text = result + " British Pounds =";
					outputTo.Text = "$" + convert.ToString("0.00") + " Us Dollars";
					conversion1.Text = "1 British Pound = 1.371907 USD";
					conversion2.Text = "1 USD = 0.72872436 British Pounds";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from British Pound to Euros
			else if (combofrom.SelectedIndex == 2 && comboto.SelectedIndex == 1)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1.1686692;
					outputFrom.Text = result + " British Pounds =";
					outputTo.Text = "€" + convert.ToString("0.00") + " Euros";
					conversion1.Text = "1 British Pound = 1.1686692 Euros";
					conversion2.Text = "1 Euro = 0.8556672 British Pounds";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			//convert from USD to Rupee
			else if (combofrom.SelectedIndex == 2 && comboto.SelectedIndex == 3)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 101.68635;
					outputFrom.Text = result + " British Pounds =";
					outputTo.Text = "₹" + convert.ToString("0.00") + " Indian Rupee";
					conversion1.Text = "1 British Pound = 101.68635 Indian Rupee";
					conversion2.Text = "1 Indian Rupee = 0.0098339397 British Pounds";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			///////////////////////////////////////////////////////////////////////////////////////////////
			//convert from Rupeee to Rupee
			if (combofrom.SelectedIndex == 3 && comboto.SelectedIndex == 3 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 1;
					outputFrom.Text = result + " Indian Rupee =";
					outputTo.Text = "₹" + convert.ToString("0.00") + " Indian Rupee";
					conversion1.Text = "1 Indian Rupee = 1 Indian Rupee";
					conversion2.Text = "1 Indian Rupee = 1 Indian Rupee";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from Rupee to USD
			else if (combofrom.SelectedIndex == 3 && comboto.SelectedIndex == 0 && !input.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 0.011492628;
					outputFrom.Text = result + " Indian Rupees =";
					outputTo.Text = "$" + convert.ToString("0.00") + " Us Dollars";
					conversion1.Text = "1 Indian Rupee = 0.011492628 USD";
					conversion2.Text = "1 USD = 74.257327 Indian Rupees";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";

				}
			}
			//convert from Rupee to Euros
			else if (combofrom.SelectedIndex == 3 && comboto.SelectedIndex == 1)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 0.013492774;
					outputFrom.Text = result + " Indian Rupees =";
					outputTo.Text = "€" + convert.ToString("0.00") + " Euros";
					conversion1.Text = "1 Indian Rupee = 0.013492774 Euros";
					conversion2.Text = "1 Euro = 87.00755 Indian Rupees";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
			//convert from Rupee to Pounds
			else if (combofrom.SelectedIndex == 3 && comboto.SelectedIndex == 2)
			{
				try
				{
					double result = double.Parse(input.Text);
					double convert = result * 0.0098339397;
					outputFrom.Text = result + " Indian Rupees =";
					outputTo.Text = "£" + convert.ToString("0.00") + " British Pounds";
					conversion1.Text = "1 Indian Rupee = 0.0098339397 British Pounds";
					conversion2.Text = "1 British Pound = 101.68635 Indian Rupees";
					Console.WriteLine(result);
				}
				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{input.Text}'");
					outputTo.Text = "Enter a number";
					outputFrom.Text = "";
				}
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			if (this.Frame != null)
			{
				this.Frame.Navigate(typeof(MainMenu));
			}
		}

		private void Combofrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void Comboto_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
