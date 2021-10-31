using System.Data.Common;
using AlcoholApi.Domain.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace AlcoholApi.Domain.Entities{

    public class Operacion : IDatos
    {
        
        private int Cantidad;
        private int Mililitro;
        private int Peso;
        private double total;
        private double factorizacion;
        private double etanol = 0.789;
        private double op;
        private double volumen;
        private double result;
        private double grado;
        private string Bebida;
        private string value;
        public void dato_1(int cantidad, string bebida)
        {
            Cantidad = cantidad;
            Bebida = bebida.ToLower();
            switch (bebida)
            {
                    case "Cerveza":
                    Mililitro = 330;
                    Cantidad = Cantidad * Mililitro;
                    grado = 5;
                    total = grado / 100 * Cantidad;
                    break;
                    case "Vino": 
                    Mililitro = 100;
                    Cantidad = Cantidad * Mililitro;
                    grado = 12;
                    total = grado / 100 * Cantidad;
                    break;
                    case "Cava": 
                    Mililitro = 100;
                    Cantidad = Cantidad * Mililitro;
                    grado = 12;
                    total = grado / 100 * Cantidad;
                    break;
                    case "Vermu":
                    Mililitro = 70;
                    Cantidad = Cantidad * Mililitro;
                    grado = 17;
                    total = grado / 100 * Cantidad;
                    break;
                    case "Licor":
                    Mililitro = 45;
                    Cantidad = Cantidad * Mililitro;
                    grado = 23;
                    total = grado / 100 * Cantidad;
                    break;
                    case "Brandy":
                    Mililitro = 45;
                    Cantidad = Cantidad * Mililitro;
                    grado = 38;
                    total = grado / 100 * Cantidad;
                    break;
                    case "Combinado":
                    Mililitro = 50;
                    Cantidad = Cantidad * Mililitro;
                    grado = 38;
                    total = grado / 100 * Cantidad;
                    break;
                default:
                Console.WriteLine("No existe este alcohol: "+bebida);
                break;
            }
            
        }

        public void dato_2(int peso)
        {
            Peso = peso;
            factorizacion = 0.15 * total;
            op = etanol * factorizacion;
            volumen = 0.08 * Peso;
            result = op / volumen;
        }
        public string ReturnTotal()
        {
                   if (result < 0.8)
                {
                    return $" {result} No es superior";
                }
                    return $" {result} Es superior";
               
        }
    }
}