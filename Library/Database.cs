using MySql.Data.MySqlClient;
using System;

public class Database
{
    private string connectionString;

    public Database()
    {
        // Replace these with your database credentials
        string server = "127.0.0.1";
        string database = "mydatabase";
        string uid = "root";
        string password = "Reshma@1986";

        connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}

