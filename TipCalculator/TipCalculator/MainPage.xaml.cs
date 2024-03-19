namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void Onfifitenbtn_Clicked(object sender, EventArgs e)
        {
            SliderTipoParcent.Value = 15;

        }

        private void Ontwentbtn_Clicked(object sender, EventArgs e)
        {
            SliderTipoParcent.Value = 20;
        }

        private void Onrdbtn_Clicked(object sender, EventArgs e)
        {
            double result = CalculeteTip();
            double roundedResult = Math.Floor(result);
            double amount = Convert.ToDouble(EnterAmount.Text.ToString());
            double totalValue = roundedResult + amount;

            TipValue.Text = roundedResult.ToString("C2");
            Totallabel.Text = totalValue.ToString("C2");

        }

        private void Onrpbtn_Clicked(object sender, EventArgs e)
        {
            double reuslt = CalculeteTip();
            double roundResult = Math.Ceiling(reuslt);
            double amount = Convert.ToDouble(EnterAmount.Text.ToString());
            double totalvalue = roundResult + amount;
            //exibir
            TipValue.Text = roundResult.ToString();
            Totallabel.Text = totalvalue.ToString();

        }

        private double CalculeteTip()
        {
            double amound = Convert.ToDouble(EnterAmount.Text.ToString());
            double parcent = SliderTipoParcent.Value;



            double result = amound * (parcent / 100);
            return result;

        }
    }
}
