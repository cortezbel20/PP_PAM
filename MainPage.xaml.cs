using TempoPrevisao_PP.ViewModels;

namespace TempoPrevisao_PP
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WeatherViewModel();
        }

       
    }

}
