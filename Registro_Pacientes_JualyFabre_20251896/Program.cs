using System;
using System.Collections.Generic;

//  JUALY FABRE 2025-1896

abstract class Persona
{
    private string nombre;
    private int edad;

    public string Nombre
    {
        get => nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacio");
            nombre = value;
        }
    }

    public int Edad
    {
        get => edad;
        set
        {
            if (value < 0 || value > 120)
                throw new ArgumentException("Edad invalida");
            edad = value;
        }
    }

    public string Cedula { get; set; }

    protected Persona(string nombre, string cedula, int edad)
    {
        Nombre = nombre;
        Cedula = cedula;
        Edad = edad;
    }

    
    public abstract void MostrarInfo();
}


class Paciente : Persona
{
    public string telefono { get; set; }
    public string GrupoSangre { get; set; }

    public Paciente(string _nombre, string cedula, int _edad,
                    string _telefono, string grupoSangre)
        : base(_nombre, cedula, _edad)
    {
        telefono = _telefono;
        GrupoSangre = grupoSangre;
    }

    public override void MostrarInfo()
    {
        Console.WriteLine($"  Nombre       : {Nombre}");
        Console.WriteLine($"  Cedula       : {Cedula}");
        Console.WriteLine($"  Edad         : {Edad} anios");
        Console.WriteLine($"  Telefono     : {telefono}");
        Console.WriteLine($"  Grupo Sangre : {GrupoSangre}");
    }
}

class PacienteUrgencias : Paciente
{
    public string Motivo { get; set; }

    public PacienteUrgencias(string nombre, string cedula, int edad,
                              string telefono, string grupoSangre, string motivo)
        : base(nombre, cedula, edad, telefono, grupoSangre)
    {
        Motivo = motivo;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"  Motivo Urgencia: {Motivo}");
    }
}

class PacienteCronico : Paciente
{
    public string Enfermedad { get; set; }
    public string Medicamento { get; set; }

    public PacienteCronico(string nombre, string cedula, int edad,
                           string telefono, string grupoSangre,
                           string enfermedad, string medicamento)
        : base(nombre, cedula, edad, telefono, grupoSangre)
    {
        Enfermedad = enfermedad;
        Medicamento = medicamento;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"  Enfermedad   : {Enfermedad}");
        Console.WriteLine($"  Medicamento  : {Medicamento}");
    }
}


class Program
{
    static List<Paciente> pacientes = new List<Paciente>();

    static void Main()
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("  SISTEMA DE REGISTRO DE PACIENTES   ");
            Console.WriteLine("══════════════════════════════════════");
            Console.WriteLine("  1. Registrar paciente general       ");
            Console.WriteLine("  2. Registrar paciente urgencias     ");
            Console.WriteLine("  3. Registrar paciente cronico       ");
            Console.WriteLine("  4. Listar todos los pacientes       ");
            Console.WriteLine("  0. Salir                            ");
            Console.WriteLine("══════════════════════════════════════");
            Console.Write("  Opcion: ");
            

            switch (Console.ReadLine())
            {
                case "1": RegistrarGeneral(); break;
                case "2": RegistrarUrgencias(); break;
                case "3": RegistrarCronico(); break;
                case "4": ListarPacientes(); break;
                case "0": salir = true; break;
                default: Console.WriteLine("Opcion invalida"); break;
            }

            if (!salir) { Console.Write("\n  Presione ENTER"); Console.ReadLine(); }
        }
    }

    static string Pedir(string label)
    {
        Console.Write($"  {label}: ");
        return Console.ReadLine();
    }

    static int PedirEntero(string label)
    {
        Console.Write($"  {label}: ");
        return int.TryParse(Console.ReadLine(), out int v) ? v : 0;
    }

    static void RegistrarGeneral()
    {
        Console.WriteLine("\n── Paciente General ──");
        pacientes.Add(new Paciente(
            Pedir("Nombre"), Pedir("Cedula"), PedirEntero("Edad"),
            Pedir("Telefono"), Pedir("Grupo sanguineo")));
        Console.WriteLine(" Registrado correctamente");
    }

    static void RegistrarUrgencias()
    {
        Console.WriteLine("\n── Paciente Urgencias ──");
        pacientes.Add(new PacienteUrgencias(
            Pedir("Nombre"), Pedir("Cedula"), PedirEntero("Edad"),
            Pedir("Telefono"), Pedir("Grupo sanguineo"), Pedir("Motivo de urgencia")));
        Console.WriteLine("   Registrado correctamente");
    }

    static void RegistrarCronico()
    {
        Console.WriteLine("\n── Paciente Cronico ──");
        pacientes.Add(new PacienteCronico(
            Pedir("Nombre"), Pedir("Cedula"), PedirEntero("Edad"),
            Pedir("Telefono"), Pedir("Grupo sanguineo"),
            Pedir("Enfermedad"), Pedir("Medicamento")));
        Console.WriteLine("   Registrado correctamente");
    }

    static void ListarPacientes()
    {
        if (pacientes.Count == 0) { Console.WriteLine("\n  Sin pacientes registrados"); return; }

        int i = 1;
        foreach (var p in pacientes)
        {
            string tipo = p is PacienteUrgencias ? "URGENCIAS"
                        : p is PacienteCronico ? "CRONICO"
                        : "GENERAL";
            Console.WriteLine($"\n  ── Paciente #{i++} [{tipo}] ──");
            p.MostrarInfo();
        }
    }
}
