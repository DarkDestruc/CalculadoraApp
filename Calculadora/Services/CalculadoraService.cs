using Calculadora.Models;
using Calculadora.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraService : ICalculadoraService
    {
        public bool ValidaNumero(int num)
        {
        if (num ==0) 
            {
                return false;
            }
        return true;

        }
        public int CalcularDosNumeros(int num1, int num2, Operaciones.Operacion operacion)
        {
            if (!ValidaNumero(num1))
            {
                return 0;
            }
            if (!ValidaNumero(num2))
            {
                return 0;
            }
            switch (operacion)
            {
                case Operaciones.Operacion.Suma:
                    return num1 + num2;
                case Operaciones.Operacion.Resta:
                    return num1- num2;  
                case Operaciones.Operacion.Multiplicacion:
                    return num1* num2;
                case Operaciones.Operacion.Division:
                    return num1/ num2;
                    default: return 0;

            }
                
        }

        public int SumarDosNumeros(int num1, int num2)
        {
            if (!ValidaNumero(num1))
            {
                return 0;
            }
            if (!ValidaNumero(num2))
            {
                return 0;
            }
            return num1 + num2;
        }
    }
}
