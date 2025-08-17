

namespace Empresa
{
    public class Desarrollador : Empleado
    {
        public string LenguajePrincipal { get; set; }

        public override double CalcularSalarioAnual()
        {
            return SalarioBase * 12;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine("=== DESARROLLADOR ===");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base: {SalarioBase}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
        }
    }
}
