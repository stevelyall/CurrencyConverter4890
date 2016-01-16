using System;
using System.Diagnostics;
using System.Globalization;

namespace Currency_Converter
{
	internal class Converter
	{
		private const double USD_TO_GBP = 0.69;
		private const double USD_TO_CAD = 1.42;
		private const double USD_TO_EUR = 0.92;
		private const double USD_TO_BRL = 4.03;
		private const double USD_TO_JPY = 118.29;

		public double Convert(Currency targetCurrency, double amount)
		{
			var convRate = 0.0;
			switch (targetCurrency)
			{
				case Currency.GBP:
					convRate = USD_TO_GBP;
					break;
				case Currency.CAD:
					convRate = USD_TO_CAD;
					break;
				case Currency.EUR:
					convRate = USD_TO_EUR;
					break;
				case Currency.BRL:
					convRate = USD_TO_BRL;
					break;
				case Currency.JPY:
					convRate = USD_TO_JPY;
					break;
			}
			return amount*convRate;
		}

		public string Format(Currency targetCurrency, double amount)
		{
			String result = "";

			switch (targetCurrency)
			{
				case Currency.GBP:
					result = amount.ToString("C", new CultureInfo("en-GB"));
					break;
				case Currency.CAD:
					result = amount.ToString("C", new CultureInfo("en-CA"));
					break;
				case Currency.EUR:
					result = amount.ToString("C", new CultureInfo("fr-FR"));
					break;
				case Currency.BRL:
					result = amount.ToString("C", new CultureInfo("pt-BR"));
					break;
				case Currency.JPY:
					result = amount.ToString("C", new CultureInfo("jp-JY"));
					break;
			  
			}
			return result;

		}
	}
}