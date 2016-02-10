using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Currency_Converter
{
	public partial class CurrencyConverterForm : Form
	{
		private readonly Converter converter = new Converter();
		private Currency _targetCurrency;

		public CurrencyConverterForm()
		{
			InitializeComponent();
			setRadioEventListeners();
			amountInput.Focus();
			brazilRadio.Select();
			rateSourceLabel.Text = converter.RateSourceString;
		}

		private void setRadioEventListeners()
		{
			this.brazilRadio.CheckedChanged += currencyRadioButtons_CheckedChanged;
			this.canadaRadio.CheckedChanged += currencyRadioButtons_CheckedChanged;
			this.europeanRadio.CheckedChanged += currencyRadioButtons_CheckedChanged;
			this.japanRadio.CheckedChanged += currencyRadioButtons_CheckedChanged;
		}

		private bool isValid(string input)
		{
			var pattern =
				new Regex(
					@"^\$?\-?([1-9]{1}[0-9]{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))$|^\-?\$?([1-9]{1}\d{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))$|^\(\$?([1-9]{1}\d{0,2}(\,\d{3})*(\.\d{0,2})?|[1-9]{1}\d{0,}(\.\d{0,2})?|0(\.\d{0,2})?|(\.\d{1,2}))\)$");
			return pattern.IsMatch(input);
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			amountInput.Clear();
			resultLabel.Text = "";
		}

		private void quitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
					       
		private void computeButton_Click(object sender, EventArgs e)
		{
			var input = amountInput.Text;
			if (input == "")
			{
				MessageBox.Show("You must enter an amount to convert.");
				return;
			}

			if (!isValid(input))
			{
				MessageBox.Show("You must enter a valid amount. For example, $2312.12 or 14.50");
				return;
			}

			if (input.StartsWith("$"))
			{
				input = input.Substring(1, input.Length - 1);
			}

			var toConvert = 0.0;
			double.TryParse(input, out toConvert);
			var result = converter.Convert(_targetCurrency, toConvert);
			resultLabel.Text = converter.Format(_targetCurrency, result);
		}

		private void CurrencyConverterForm_Load(object sender, EventArgs e)
		{
		}

		private void currencyRadioButtons_CheckedChanged(object sender, EventArgs e)
		{
			resultLabel.Text = "";
			if (brazilRadio.Checked)
			{
				_targetCurrency = Currency.BRL;
			}
			else if (canadaRadio.Checked)
			{
				_targetCurrency = Currency.CAD;
			}
			else if (europeanRadio.Checked)
			{
				_targetCurrency = Currency.EUR;
			}
			else if (japanRadio.Checked)
			{
				_targetCurrency = Currency.JPY;
			}
	
		}


 }
}