using Npgsql;

public static class Db
{
    public static string ConnString =>
        Environment.GetEnvironmentVariable("IT008")
        ?? throw new InvalidOperationException("IT008 environment variable not found.");

    public static NpgsqlConnection Open()
    {
        var conn = new NpgsqlConnection(ConnString);
        conn.Open();
        return conn;
    }
}
