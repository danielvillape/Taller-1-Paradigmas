class Persona
{
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Persona() { }

    public Persona(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }

    public override string ToString() => $"{Nombre} ({Email})";
}
