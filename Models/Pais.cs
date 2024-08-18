public class Pais
{
    public int IdPais { get; set; }
    public string Nombre { get; set; }
    public string Bandera { get; set; }
    public DateTime FechaFundacion { get; set; }

    public Pais() { }

    public Pais(int idPais, string nombre, string bandera, DateTime fechaFundacion)
    {
        IdPais = idPais;
        Nombre = nombre;
        Bandera = bandera;
        FechaFundacion = fechaFundacion;
    }
}
