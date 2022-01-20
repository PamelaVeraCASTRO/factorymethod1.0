using System;
using System.Collections.Generic;
using System.Text;

namespace factorymethod1._0
{
    class Cerveza:BEBIDAEMBRIAGANTE
    {
        public override int NiveldeAlcohol()
        {
            return 10;
        }
    }
}
