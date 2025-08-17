using System;
using Empresa;

class Program
{
    static void Main(string[] args)
    {
       
        Gerente gerente = new Gerente
        {
            ID = 1,
            Nombre = "Ana López",
            SalarioBase = 3000,
            BonoAnual = 10000
        };

        Desarrollador dev = new Desarrollador
        {
            ID = 2,
            Nombre = "Harry Potter",   
            SalarioBase = 2500,
            LenguajePrincipal = "C#"
        };

        Contador contador = new Contador
        {
            ID = 3,
            Nombre = "Kevin James",    
            SalarioBase = 2200,
            HorasExtras = 100,
            PagoPorHoraExtra = 15
        };

       
        gerente.MostrarInformacion();
        Console.WriteLine($"Salario Anual: {gerente.CalcularSalarioAnual()}");
        Console.WriteLine();

        dev.MostrarInformacion();
        Console.WriteLine($"Salario Anual: {dev.CalcularSalarioAnual()}");
        Console.WriteLine();

        contador.MostrarInformacion();
        Console.WriteLine($"Salario Anual: {contador.CalcularSalarioAnual()}");
        Console.WriteLine();
    }
}