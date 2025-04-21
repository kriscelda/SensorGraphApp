using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

public static class DatabaseHelper
{
    private static SQLiteConnection _dbConnection;
    private static readonly string _databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AppData.db3");

    public static void InitializeDatabase()
    {
        if (_dbConnection == null)
        {
            _dbConnection = new SQLiteConnection(_databasePath);
            _dbConnection.CreateTable<SensorData>();
        }
    }

    public static int Insert<T>(T item) where T : new()
    {
        InitializeDatabase();
        return _dbConnection.Insert(item);
    }

    public static List<T> GetAll<T>() where T : new()
    {
        InitializeDatabase();
        return _dbConnection.Table<T>().ToList();
    }
}

public class SensorData
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public double Value { get; set; }
}
