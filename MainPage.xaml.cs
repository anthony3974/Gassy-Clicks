namespace Gassy_Clicks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            FE.Text = "10";
            CoG.Text = "1.6";
        }

        double dis;
        double fe;
        double cog;

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Error.Text = "";

                dis = Convert.ToDouble(distance.Text);
                fe = Convert.ToDouble(FE.Text);
                cog = Convert.ToDouble(CoG.Text);

                double tot = ((dis / 100) * fe) * cog;
                total.Text = tot.ToString("C");

            }
            catch
            {
                Error.Text = "Not a number";
            }

        }
    }

}
