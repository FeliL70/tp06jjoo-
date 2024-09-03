using System.Data.SqlClient;
using Dapper;
using TP06_Cordero_Lipreti.Models;

public static class BD
{
    private static string connectionString = @"Server=localhost\SQLEXPRESS;DataBase=JJOO;Trusted_Connection=true;";

    public static void AgregarDeportista(Deportista dep)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "INSERT INTO Deportistas (Apellido, Nombre, FechaNacimiento, Foto, IdPais, IdDeporte) VALUES (@Apellido, @Nombre, @FechaNacimiento, @Foto, @IdPais, @IdDeporte)";
            connection.Execute(sql, dep);
        }
    }

    public static void EliminarDeportista(int idDeportista)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "DELETE FROM Deportistas WHERE IdDeportista = @IdDeportista";
            connection.Execute(sql, new { IdDeportista = idDeportista });
        }
    }

    public static Deporte VerInfoDeporte(int idDeporte)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Deportes WHERE IdDeporte = @IdDeporte";
            return connection.QueryFirstOrDefault<Deporte>(sql, new { IdDeporte = idDeporte });
        }
    }

    public static Pais VerInfoPais(int idPais)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Paises WHERE IdPais = @IdPais";
            return connection.QueryFirstOrDefault<Pais>(sql, new { IdPais = idPais });
        }
    }

    public static Deportista VerInfoDeportista(int idDeportista)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Deportistas WHERE IdDeportista = @IdDeportista";
            return connection.QueryFirstOrDefault<Deportista>(sql, new { IdDeportista = idDeportista });
        }
    }

    public static List<Pais> ListarPaises()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Paises";
            return connection.Query<Pais>(sql).ToList();
        }
    }

    public static List<Deporte> ListarDeportes()
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Deportes";
            return connection.Query<Deporte>(sql).ToList();
        }
    }

    public static List<Deportista> ListarDeportistasPorDeporte(int idDeporte)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Deportistas WHERE IdDeporte = @IdDeporte";
            return connection.Query<Deportista>(sql, new { IdDeporte = idDeporte }).ToList();
        }
    }

    public static List<Deportista> ListarDeportistasPorPais(int idPais)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            var sql = "SELECT * FROM Deportistas WHERE IdPais = @IdPais";
            return connection.Query<Deportista>(sql, new { IdPais = idPais }).ToList();
        }
    }
}