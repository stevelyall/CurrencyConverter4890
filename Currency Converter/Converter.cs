using System.Globalization;

namespace Currency_Converter
{
	internal class Converter
	{
		private readonly RateManager _rateManager;

		public string RateSourceString
		{
			get
			{
				if (_rateManager.DateRetrieved == null)
				{
					return "Using fixed conversion rates";
				}
				return "Using conversion rates for " + _rateManager.DateRetrieved + " from fixer.io";
			}
		}

		public Converter()
		{
			_rateManager = new RateManager();
		}

		public double Convert(Currency targetCurrency, double amount)
		{
			var convRate = 0.0;
			switch (targetCurrency)
			{
				case Currency.GBP:
					convRate = _rateManager.USDtoGBP;
					break;
				case Currency.CAD:
					convRate = _rateManager.USDtoCAD;
					break;
				case Currency.EUR:
					convRate = _rateManager.USDtoEUR;
					break;
				case Currency.BRL:
					convRate = _rateManager.USDtoBRL;
					break;
				case Currency.JPY:
					convRate = _rateManager.USDtoJPY;
					break;
			}
			return amount*convRate;
		}

		public string Format(Currency targetCurrency, double amount)
		{
			var result = "";

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