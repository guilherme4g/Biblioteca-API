using System;
using Npgsql;

namespace Biblioteca_API.Databases{
  public static class PostgreSQLDatabase {
    
    private static NpgsqlConnection connection = null;

    public static NpgsqlConnection getConnection() {
      if (connection == null) {
        connection = new NpgsqlConnection("Host=localhost;Username=admbiblioteca;Password=biblioteca123;Database=biblioteca");
        connection.Open();
      }
      return connection;
    }

  }
}