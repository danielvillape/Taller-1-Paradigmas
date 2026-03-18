class Cliente : Persona
{
    public string Documento { get; set; } = string.Empty;

    public Cliente() { }

    public Cliente(string nombre, string email, string documento)
        : base(nombre, email)
    {
        Documento = documento;
    }

    public override string ToString() => $"Cliente {Nombre} - {Documento}";
}
