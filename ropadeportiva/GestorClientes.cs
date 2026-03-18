using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

class GestorClientes
{
    private readonly string _ruta;
    public List<Cliente> Clientes { get; } = new();

    public GestorClientes(string rutaCsv)
    {
        _ruta = rutaCsv;
        Cargar();
    }

    public void Cargar()
    {
        Clientes.Clear();
        if (!File.Exists(_ruta)) return;

        using var reader = new StreamReader(_ruta);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var registros = csv.GetRecords<Cliente>();
        Clientes.AddRange(registros);
    }

    public void Guardar()
    {
        using var writer = new StreamWriter(_ruta);
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(Clientes);
    }

    public bool Agregar(Cliente cliente)
    {
        if (Clientes.Exists(c => c.Documento == cliente.Documento))
            return false;
        Clientes.Add(cliente);
        Guardar();
        return true;
    }

    public bool Eliminar(string documento)
    {
        var cliente = Clientes.Find(c => c.Documento == documento);
        if (cliente == null) return false;
        Clientes.Remove(cliente);
        Guardar();
        return true;
    }
}
