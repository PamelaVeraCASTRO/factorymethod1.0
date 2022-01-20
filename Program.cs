using System;
using System.Collections.Generic;
using System.Text;

namespace factorymethod1._0
{
    class Program
    {
        static void Main (string[] args)
        {
            // CON EL FACTORYMETHOD ayudara a imprimir por pantalla el nivel de alcohol
            Console.WriteLine("Niveles de Alcohol de las siguientes bebidas:");
            Console.WriteLine("Cerveza-Mojito-Michelada-Tequila-Ron_Blanco-Vodka");
            BEBIDAEMBRIAGANTE Cerveza = Creadora.CreadoraB(Creadora.Cerveza);
            Console.WriteLine(Cerveza.NiveldeAlcohol());
            BEBIDAEMBRIAGANTE Mojito = Creadora.CreadoraB(Creadora.Mojito);
            Console.WriteLine(Mojito.NiveldeAlcohol());
            BEBIDAEMBRIAGANTE Michelada = Creadora.CreadoraB(Creadora.Michelada);
            Console.WriteLine(Michelada.NiveldeAlcohol());
            BEBIDAEMBRIAGANTE Tequila = Creadora.CreadoraB(Creadora.Tequila);
            Console.WriteLine(Tequila.NiveldeAlcohol());
            BEBIDAEMBRIAGANTE Ron_Blanco = Creadora.CreadoraB(Creadora.Ron_Blanco);
            Console.WriteLine(Ron_Blanco.NiveldeAlcohol());
            BEBIDAEMBRIAGANTE Vodka = Creadora.CreadoraB(Creadora.Vodka);
        }
    }
}
