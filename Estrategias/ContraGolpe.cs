using PatronStrategy.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Estrategias
{
    public class ContraGolpe : IEstrategia
    {
        public void Jugar()
        {
            Console.WriteLine("Defender y jugar a contra");
        }
    }
}
