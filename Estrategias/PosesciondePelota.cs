using PatronStrategy.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Estrategias
{
    public class PosesciondePelota : IEstrategia
    {
        public void Jugar()
        {
            Console.WriteLine("Mantener la pelota" + ", hacer pases");
        }
    }
}
