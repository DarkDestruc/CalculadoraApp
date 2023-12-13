using Calculadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services.Interfaces
{
    public interface ICalculadoraService
    {
        public int SumarDosNumeros(int num1, int num2);
        public int CalcularDosNumeros(int num1, int num2, Operaciones.Operacion operacion);
    }
}
