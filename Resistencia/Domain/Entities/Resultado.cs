using System;
using Resistencia.Domain.Interfaces;

namespace Resistencia.Domain.Entities
{
    public class Resultado : Ioperaciones
    {
        private string Banda_1;
        private string Banda_2;
        private string Banda_3;
        private string Banda_4;
        private string valor_1;
        private string valor_2;
        private string resultado;
        private int valor = 0;
        public double suma = 0.0;
        private double resultado_2 = 0.0;
        private double resultado_3 = 0.0;
        private double mas = 0.0;
        private double menos =0.0;

        
        public void banda_1(string Banda1)
        {
            Banda_1 = Banda1.ToLower();
            switch(Banda1){
                case "Negro":
                break;
                case "Cafe":
                valor_1 = "1";
                break;
                case "Rojo":
                valor_1 = "2";
                break;
                case "Naranja":
                valor_1 = "3";
                break;
                case "Amarillo":
                valor_1 = "4";
                break;
                case "Verde":
                valor_1 = "5";
                break;
                case "Azul":
                valor_1 = "6";
                break;
                case "Violeta":
                valor_1 = "7";
                break;
                case "Gris":
                valor_1 = "8";
                break;
                case "Blanco":
                valor_1 = "9";
                break;
                
            }
        }
        public void banda_2(string Banda2)
        {
            Banda_2 = Banda2.ToLower();
            switch(Banda2){
                case "Negro":
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Cafe":
                valor_2 = "1";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Rojo":
                valor_2 = "2";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Naranja":
                valor_2 = "3";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Amarillo":
                valor_2 = "4";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Verde":
                valor_2 = "5";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Azul":
                valor_2 = "6";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Violeta":
                valor_2 = "7";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Gris":
                valor_2 = "8";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                case "Blanco":
                valor_2 = "9";
                resultado = valor_1 + valor_2;
                valor = int.Parse(resultado);
                break;
                
            }
        }
        public void banda_3(string Banda3)
        {

            Banda_3 = Banda3.ToLower();
            switch(Banda3){
                case "Negro":
                resultado_2 = 1;
                suma = valor * resultado_2;
                break;
                case "Cafe":
                resultado_2 = 10;
                suma = valor * resultado_2;
                break;
                case "Rojo":
                resultado_2 = 100;
                suma = valor * resultado_2;
                break;
                case "Naranja":
                resultado_2 = 1000;
                suma = valor * resultado_2;
                break;
                case "Amarillo":
                resultado_2 = 10000;
                suma = valor * resultado_2;
                break;
                case "Verde":
                resultado_2 = 100000;
                suma = valor * resultado_2;
                break;
                case "Azul":
                resultado_2 = 1000000;
                suma = valor * resultado_2;
                break;
                case "Violeta":
                resultado_2 = 10000000;
                suma = valor * resultado_2;
                break;
                case "Gris":
                resultado_2 = 100000000;
                suma = valor * resultado_2;
                break;
                case "Blanco":
                resultado_2 = 1000000000;
                suma = valor * resultado_2;
                break;
                
            }
        }
        public void banda_oro(string Banda4)
        {
            Banda_4 = Banda4.ToLower();

                if(Banda4 == "Dorado"){
                resultado_3 = suma * 0.5/10;
                }
                if(Banda4 == "Plata"){
                resultado_3 = suma * 0.10/10;
                }
             mas= suma + resultado_3;
         menos= suma - resultado_3;  
           
        }

        public string Returnoperacion()
        {
             
             return $"El valor es: {suma} y la tolerancia es: {resultado_3} El rango de toleracia si tiene mas el {resultado_3} es de: {mas} El rango de tolerancia si tiene menos el {resultado_3} es de : {menos} ";
        }

        
    }

    
}