using Calculadora.Models;
using Calculadora.Services;
using Calculadora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ViewModels
{
    public class CalculadoraPageViewModel : INotifyPropertyChanged
    {
        private readonly ICalculadoraService calculadoraService;
        private int resultado;

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public Operaciones.Operacion SeleccionarOperacion { get; set; }
        public int Resultado
        {
            get => resultado; set
            {
                resultado = value;
                OnPropertyChanged();
            }
        }
       //Se Cran Commands
        public Command HacerCalculoCommand { get; set; }

        public Command SeleccionarSumarCommand { get; set; }
        public Command SeleccionarRestaCommand { get; set; }
        public Command SeleccionarMultiCommand { get; set; }
        public Command SeleccionarDivdCommand { get; set; }


        public CalculadoraPageViewModel(ICalculadoraService calculadoraService )
        {
            this.calculadoraService = calculadoraService;
            HacerCalculoCommand = new Command(CalcularDosNumeros);
            SeleccionarSumarCommand= new Command(SeleccionarOperacionSuma);
            SeleccionarRestaCommand = new Command(SeleccionarOperacionResta);
            SeleccionarMultiCommand = new Command(SeleccionarOperacionMultiplicacion);
            SeleccionarDivdCommand = new Command(SeleccionarOperacionDivision);
        }
        //Implementacion de los Commands
        private void SeleccionarOperacionSuma()
        {
            SeleccionarOperacion = Operaciones.Operacion.Suma;
        }
        private void SeleccionarOperacionResta()
        {
            SeleccionarOperacion = Operaciones.Operacion.Resta;
        }
        private void SeleccionarOperacionMultiplicacion()
        {
            SeleccionarOperacion = Operaciones.Operacion.Multiplicacion;
        }
        private void SeleccionarOperacionDivision()
        {
            SeleccionarOperacion = Operaciones.Operacion.Division;
        }

        private void CalcularDosNumeros() 
        {
            Resultado = calculadoraService.CalcularDosNumeros(Numero1, Numero2, SeleccionarOperacion);
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
