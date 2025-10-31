namespace KalkulatorNapiwkow
{
    public partial class MainPage : ContentPage
    {
        int tipPercentage = 15;
        double currencyMultiplier = 1;
        double bill = 0;
        public MainPage()
        {
            InitializeComponent();
            LblSliderValueDisplay.Text = "a";
        }
        async private void onValueChangeSlider(object sender, EventArgs e)
        {
            tipPercentage = Convert.ToUInt16(((Slider)sender).Value);
            LblSliderValueDisplay.Text = tipPercentage.ToString("0.00");
            CalculateTip();
        }
        private void CalculateTip(object sender, EventArgs e)
        {
            if (inpValue.Text == null || !inpValue.Text.Trim().All(char.IsDigit) || inpValue.Text == "")
            {
                LblTipAmount.Text = "Wpisz poprawną wartość rachunku!";
                bill = 0;
                LblTotalAmount.Text = "";
                return;
            }
            CalculateTip();
        }
        private void CalculateTip()
        {
            if(inpValue.Text == null || !inpValue.Text.Trim().All(char.IsDigit) || inpValue.Text == "")
            {
                LblTipAmount.Text = "Wpisz poprawną wartość rachunku!";
                LblTotalAmount.Text = "";
                return;
            }
            bill = Convert.ToInt16(inpValue.Text.Trim());
            LblTipAmount.Text = "Napiwek: " + ( (bill * tipPercentage / 100)  * currencyMultiplier).ToString("0.00");
            LblTotalAmount.Text = "Do zapłaty: " + ( ( bill + (bill * tipPercentage / 100)) * currencyMultiplier ).ToString("0.00");

        }
        private void ClearFields(object sender, EventArgs e)
        {
            tipPercentage = 15;
            currencyMultiplier = 1;
            bill = 0;
            rbPLN.IsChecked = true;
            inpValue.Text = "";
            sliderTip.Value = 15;
            LblTipAmount.Text = "Wyczyszczono!";
        }
        private void rbHandler(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "PLN":
                    currencyMultiplier = 1;
                    CalculateTip();
                    break;
                case "EUR":
                    currencyMultiplier = 4.25;
                    CalculateTip();
                    break;
                case "USD":
                    currencyMultiplier = 3.60;
                    CalculateTip();
                    break;
            }
        }
    }
}
