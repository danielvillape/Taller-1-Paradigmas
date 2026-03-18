class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public decimal Precio { get; set; }

    public Producto() { }

    public Producto(int id, string nombre, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
    }

    public override string ToString() => $"[{Id}] {Nombre} - ${Precio:0.00}";
}
