public class Deporte
{
    public int IdDeporte { get; set; }
    public string Nombre { get; set; }
    public string Foto { get; set; }

    public Deporte() { }

    public Deporte(int idDeporte, string nombre, string foto)
    {
        IdDeporte = idDeporte;
        Nombre = nombre;
        Foto = foto;
    }
}
