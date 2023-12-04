using PatronStrategy.Estrategias;
using PatronStrategy.Implementacion;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("México");
        EquiposdeFutbol mexico = new EquiposdeFutbol();
        mexico.SetEstrategia(new PresionAlta());
        mexico.MostrarEstrategia();

        Console.WriteLine("Argentina");
        EquiposdeFutbol argentina = new EquiposdeFutbol();
        argentina.SetEstrategia(new ContraGolpe());
        argentina.MostrarEstrategia();

        Console.WriteLine("Brasil");
        EquiposdeFutbol brasil = new EquiposdeFutbol();
        brasil.SetEstrategia(new PosesciondePelota());
        brasil.MostrarEstrategia();
    }
}
