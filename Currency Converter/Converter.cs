using System;
using System.Diagnostics;
using System.Globalization;

namespace Currency_Converter
{
	internal class Converter
	{
		private RateManager rateManager;

	 public Converter()
	 {
	  rateManager = new RateManager();
	 }

  public double Convert(Currency targetCurrency, double amount)
		{
			var convRate = 0.0;
			switch (targetCurrency)
			{
				case Currency.GBP:
	 				convRate = rateManager.USDtoGBP;
					break;
				case Currency.CAD:
					convRate = rateManager.USDtoCAD;
					break;
				case Currency.EUR:
					convRate = rateManager.USDtoEUR;
					break;
				case Currency.BRL:
					convRate = rateManager.USDtoBRL;
					break;
				case Currency.JPY:
					convRate = rateManager.USDtoJPY;
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