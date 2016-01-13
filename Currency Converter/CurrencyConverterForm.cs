using System;
using System.Windows.Forms;

namespace Currency_Converter
{
	public partial class CurrencyConverterForm : Form
	{
		private readonly Converter converter = new Converter();
		private Currency _targetCurrency = Currency.BRL;

		public CurrencyConverterForm()
		{
			InitializeComponent();
			amountInput.Focus();
			brazilRadio.Select();
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
		 
		// TODO numeric only in TextBox
		private void computeButton_Click(object sender, EventArgs e)
		{
			if (amountInput.Text == "")
			{
				MessageBox.Show("You must enter an amount to convert.");
				return;
			}
			double toConvert = 0.0;
			Double.TryParse(amountInput.Text, out toConvert);
			double result = converter.Convert(_targetCurrency, toConvert);
			resultLabel.Text = result.ToString("C");

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