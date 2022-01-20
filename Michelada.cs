using System;
using System.Collections.Generic;
using System.Text;

namespace factorymethod1._0
{
    // Hereda de la clase producto
    class Michelada: BEBIDAEMBRIAGANTE
    {
        //  utilizamos el metod y un return acompañado de un numero para poder llamar al metodo 
        public override int NiveldeAlcohol()
        {
            return 5;
        }
    }
}
