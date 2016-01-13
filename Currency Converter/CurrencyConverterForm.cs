using System;
using System.Windows.Forms;

namespace Currency_Converter
{
	public partial class CurrencyConverterForm : Form
	{
		private Converter converter = new Converter();
		private Currency targetCurrency = Currency.BRL;

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

		private void computeButton_Click(object sender, EventArgs e)
		{
		}

		private void CurrencyConverterForm_Load(object sender, EventArgs e)
		{
		}

		private void currencyRadioButtons_CheckedChanged(object sender, EventArgs e)
		{
			if (brazilRadio.Checked)
			{
				targetCurrency = Currency.BRL;
			}
			else if (canadaRadio.Checked)
			{
				targetCurrency = Currency.CAD;
			}
			else if (europeanRadio.Checked)
			{
				targetCurrency = Currency.EUR;
			}
			else if (japanRadio.Checked)
			{
				targetCurrency = Currency.JPY;
			}
		}
	}
}