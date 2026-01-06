namespace PolymorphismExercises
{
    partial class Program
    {
        class DbConnection
        {
            private string? _connectionString;
            private TimeSpan _timeout;

            public DbConnection(string? connectionString)
            {
                if (connectionString == null)
                {
                    throw new ArgumentNullException();
                }
                this._connectionString = connectionString;
                this._timeout = TimeSpan.FromSeconds(30);
            }

            public virtual void OpenConnection()
            {

            }

            public virtual void CloseConnection()
            {

            }
        }

        class SqlConnection : DbConnection
        {
            public SqlConnection(string? connectionString)
                : base(connectionString)
            {

            }
            public override void OpenConnection()
            {
                Console.WriteLine("Opening SQL Connection.");
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closing SQL Connection.");
            }
        }

        class OracleConnection : DbConnection
        {
            public OracleConnection(string? connectionString)
                : base(connectionString)
            {

            }
            public override void OpenConnection()
            {
                Console.WriteLine("Opening Oracle Connection.");
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closing Oracle Connection.");
            }
        }
    }
}
