namespace ropadeportiva
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string email;
        private string telefono;

        // Constructor
        public Cliente(int id, string nombre, string email, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.telefono = telefono;
        }

        // Getters
        public int GetId()
        {
            return id;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetEmail()
        {
            return email;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        // Método ToString para mostrar información
        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Email: {email}, Teléfono: {telefono}";
        }
    }
}
