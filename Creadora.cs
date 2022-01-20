using System;
using System.Collections.Generic;
using System.Text;

namespace factorymethod1._0
{
    // Esta clase creara objetos  y aplicamos el FACTORYMETHOD
    public class Creadora
    {
        public const int Michelada = 1;
        public const int Cerveza = 2;
        public const int Mojito = 3;
        public const int Tequila = 4;
        public const int Vodka = 5;
        public const int Ron_Blanco = 6;
        public static BEBIDAEMBRIAGANTE CreadoraB(int tipo)
        {
            switch (tipo)
            {
                case Michelada:
                    return new Michelada();
                case Mojito:
                    return new Mojito();
                case Cerveza:
                    return new Cerveza();
                case Tequila:
                    return new Tequila();
                case Vodka:
                    return new Vodka();
                case Ron_Blanco:
                    return new Ron_Blanco();
                default: return null;
            }
        }
    }
}
