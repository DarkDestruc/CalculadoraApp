using Calculadora.ViewModels;

namespace Calculadora.Views
{
    public partial class CalculadoraPage : ContentPage
    {
        public CalculadoraPage(CalculadoraPageViewModel calculadoraPageViewModel)
        {
            InitializeComponent();
            BindingContext=calculadoraPageViewModel;
        }
        
    }
}