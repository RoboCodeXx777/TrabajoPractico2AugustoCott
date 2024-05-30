using System;
using System.Collections.Generic;
using TrabajoPractico2AugustoCott.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Persona persona1 = new Persona("Juan", 30, "masculino");
        Persona persona2 = new Persona("María", 25, "femenino");

        persona1.Hablar();
        persona2.Hablar();

        Barco barco1 = new Barco(50, 10); // El cargamento es de 50 y la tripulacion se encuentra en 10
        Barco barco2 = new Barco(30, 15); // El cargamento es de 30 y la tripulacion se encuentra en 15
        Barco barco3 = new Barco(25, 10); // El cargamento es de 25 y la tripulacion se encuentra en 10

        Console.WriteLine(barco1);
        Console.WriteLine("¿Vale la pena saquear?: " + barco1.ValeLaPenaSaquear());

        Console.WriteLine(barco2);
        Console.WriteLine("¿Vale la pena saquear?: " + barco2.ValeLaPenaSaquear());

        Console.WriteLine(barco3);
        Console.WriteLine("¿Vale la pena saquear?: " + barco3.ValeLaPenaSaquear());

        List<string> aliadosTanque1 = new List<string> { "EE.UU.", "Reino Unido", "Francia" };
        List<string> aliadosTanque2 = new List<string> { "Alemania", "Italia", "Japón" };

        Tanque tanque1 = new Tanque("Abrams", "EE.UU.", 1980, 62, aliadosTanque1);
        Tanque tanque2 = new Tanque("Leopard", "Alemania", 1979, 55, aliadosTanque2);

        tanque1.Batalla(tanque2);

        Bloque miBloque = new Bloque(5, 3, 4);
        Console.WriteLine($"Dimensiones: Largo = {miBloque.ObtenerLargo()}, Ancho = {miBloque.ObtenerAncho()}, Alto = {miBloque.ObtenerAlto()}");
        Console.WriteLine($"Volumen: {miBloque.ObtenerVolumen()}");
        Console.WriteLine($"Área de Superficie: {miBloque.ObtenerAreaSuperficie()}");
    }
}