public class Deportista
{
    public int IdDeportista { get; set; }
    public string Apellido { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Foto { get; set; }
    public int IdPais { get; set; }
    public int IdDeporte { get; set; }

    public Deportista() { }

    public Deportista(int idDeportista, string apellido, string nombre, DateTime fechaNacimiento, string foto, int idPais, int idDeporte)
    {
        IdDeportista = idDeportista;
        Apellido = apellido;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;
        Foto = foto;
        IdPais = idPais;
        IdDeporte = idDeporte;
    }
}
