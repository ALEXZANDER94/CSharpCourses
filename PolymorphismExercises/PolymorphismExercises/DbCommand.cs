namespace PolymorphismExercises
{
    partial class Program
    {
        class DbCommand
        {
            private readonly DbConnection _connection;
            private readonly string _instruction;
            public DbCommand(DbConnection dbConnection, string instruction)
            {
                if (dbConnection == null)
                {
                    throw new ArgumentNullException();
                }
                if(instruction == null)
                {
                    throw new ArgumentNullException();
                }
                this._connection = dbConnection;
                this._instruction = instruction;
            }


            public void Execute()
            {
                this._connection.OpenConnection();
                Thread.Sleep(1);
                Console.WriteLine(string.Format("Executing {0} instruction", this._instruction));
                Thread.Sleep(1);
                this._connection.CloseConnection();
            }

        }
    }
}
