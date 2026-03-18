class Ropa : Producto
{
    public string Talla { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;

    public Ropa() { }

    public Ropa(int id, string nombre, decimal precio, string talla, string color)
        : base(id, nombre, precio)
    {
        Talla = talla;
        Color = color;
    }

    public override string ToString() => $"[{Id}] {Nombre} ({Talla}, {Color}) - ${Precio:0.00}";
}
