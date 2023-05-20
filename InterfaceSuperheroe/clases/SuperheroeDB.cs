using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSuperheroe.clases
{
    internal class SuperheroeDB
    {
        public readonly string cadenaConexion ="Data Source=C:\\Tmp\\heroes.db";
        private readonly sqliteconnection conexion;

        public SuperheroeDB(string cadenaCon)
        {
            conexion = new sqliteconnection(cadenaCon);
        }
    }
    public SuperheroeDB()
    {
       
        conexion = new sqliteconnection(cadenaConexion);
    }
    public void CrearTablaHeroe()
    {
        string mensaje = "";
        try
        {
            conexion.Open();
            string sql = @"CREATE TABLE IF NOT EXISTS SuperHeroes (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Nombre TEXT,
                                        fuerza INTEGER,
                                        agilidad INTEGER);";
            SqliteCommand comando = new SqliteCommand(sql, conexion);
            comando.ExecuteNonQuery();
            Console.WriteLine("Base de datos y tabla creadas con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al crear la tabla: " + ex.Message);
        }
        finally
        {
            conexion.Close();
        }
    }

    public ISuperheroe CrearHeroe(ISuperHeroe heroe)
    {
        try
        {
            conexion.Open();
            string sql = @"INSERT INTO Superheroe (nombre, fuerza, agilidad) VALUES(@nombre,@fuerza,@agilidad);";
            SqLiteCommand comando = new sqli
        }
        

        
    }

}

