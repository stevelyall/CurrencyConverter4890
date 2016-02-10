using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Currency_Converter
{
	internal class RateManager
	{
		private const string requestEndpoint = "http://api.fixer.io/latest?base=USD&symbols=GBP,CAD,EUR,BRL,JPY";

		private double _usd_to_gbp = 0.69;
		private double _usd_to_cad = 1.42;
		private double _usd_to_eur = 0.92;
		private double _usd_to_brl = 4.03;
		private double _usd_to_jpy = 118.29;

		public RateManager()
		{
			var ratesObject = getRatesFromSever();
			if (ratesObject != null)
			{
		   
			    double.TryParse(ratesObject["rates"]["GBP"].ToString(), out _usd_to_gbp);
				double.TryParse(ratesObject["rates"]["CAD"].ToString(), out _usd_to_cad);
				double.TryParse(ratesObject["rates"]["EUR"].ToString(), out _usd_to_eur);
				double.TryParse(ratesObject["rates"]["BRL"].ToString(), out _usd_to_brl);
				double.TryParse(ratesObject["rates"]["JPY"].ToString(), out _usd_to_jpy);
				DateRetrieved = ratesObject["date"].ToString();
			}
		}

		public String DateRetrieved { get; set; }

		public double USDtoGBP
		{
			get { return _usd_to_gbp; }
		}

		public double USDtoCAD
		{
			get { return _usd_to_cad; }
		}

		public double USDtoEUR
		{
			get { return _usd_to_eur; }
		}

		public double USDtoBRL
		{
			get { return _usd_to_brl; }
		}

		public double USDtoJPY
		{
			get { return _usd_to_jpy; }
		}

		private JObject getRatesFromSever()
		{
			var request = WebRequest.Create(requestEndpoint);
			string responseString;


			try
			{
				var response = request.GetResponse();
				var reader = new StreamReader(response.GetResponseStream());
				responseString = reader.ReadToEnd();
			}
			catch (WebException e)
			{
				Debug.WriteLine(e);
				return null;
			}

			return JObject.Parse(responseString);
		}
	}
}