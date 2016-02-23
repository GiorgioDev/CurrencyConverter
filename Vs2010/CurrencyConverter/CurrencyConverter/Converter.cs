using System;
using System.Linq;
using System.Windows.Forms;
using CurrencyConverter.BL;
namespace CurrencyConverter
{
    public partial class Converter : Form
    {
        private ExchangeRateCollection rates;
        private CurrencyConverter.BL.CurrencyConverter converter;
        public Converter()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            rates = new ExchangeRateCollection();
            rates.AddOrUpdateExchangeRate(new ExchangeRate(ISOCodes.Usd, ISOCodes.Ars, 8.8));
            rates.AddOrUpdateExchangeRate(new ExchangeRate(ISOCodes.Ars, ISOCodes.Usd, 0.084));
            rates.AddOrUpdateExchangeRate(new ExchangeRate(ISOCodes.Eur, ISOCodes.Ars, 11));

            bindingSource1.DataSource = rates.GetAllItems();

            converter = new CurrencyConverter.BL.CurrencyConverter();
            converter.SetExchangeRateCollection(rates);
            
        }

        private void DoConvertion(string from, string to, double amount)
        {
            try
            {
                resultValueLabel.Text = converter.Convert(from, to, amount).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Event Handlers
        private void AmountValueTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '\r'))
            {
                e.Handled = true;
                DoConvertion(fromValueTextBox.Text, toValueTextBox.Text, double.Parse(amountValueTextBox.Text));
            }
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            DoConvertion(fromValueTextBox.Text, toValueTextBox.Text, double.Parse(amountValueTextBox.Text));
        }

        private void RatesDataGridViewRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ExchangeRate selectedRate = rates.GetAllItems().ElementAt(e.RowIndex);
            fromValueTextBox.Text = selectedRate.IsoFrom;
            toValueTextBox.Text = selectedRate.IsoTo;
        }

        #endregion
    }
}