using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronStrategy.Implementacion
{
    public class EquiposdeFutbol
    {
        public int NumeroDeJugadores { get; set; }
        public string? Director { get; set; }
        private IEstrategia _estrategia;
        public void SetEstrategia(IEstrategia estrategia)
        {
            _estrategia = estrategia;
        }
        public void MostrarEstrategia()
        {
            _estrategia.Jugar();
        }
    }
}
