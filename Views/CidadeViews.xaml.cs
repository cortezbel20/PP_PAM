using TempoPrevisao_PP.ViewModels;

namespace TempoPrevisao_PP.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new WeatherViewModel();
    }
}