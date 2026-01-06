using System;

namespace PolymorphismExercises
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // 1) Your job is to represent these commonalities in a base class called DbConnection. This class should have two properties:
            //      ConnectionString: string
            //      Timeout : TimeSpan
            // Derive two classes SqlConnection and OracleConnection from DbConnection and provide a simple implementation of opening and closing connections using Console.WriteLine()
            try
            {
                var sqlConnection = new SqlConnection("someconnectionstringhere");
                sqlConnection.OpenConnection();
                Thread.Sleep(2000);
                sqlConnection.CloseConnection();
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("SqlConnection : Null Argument Exception");
            }

            try
            {
                var oracleConnection = new OracleConnection("someconnectionstringhere");
                oracleConnection.OpenConnection();
                Thread.Sleep(2000);
                oracleConnection.CloseConnection();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("OracleConnection : Null Argument Exception");
            }

            Console.WriteLine();

            // 2) Design a class called DbCommand for executing an instruction against the database
            // Each DbCommand should also have the instruction to be sent to the database
            // Each command should be executable. So we need to create a method called Execute()

            try
            {
                var sqlConnection = new SqlConnection("someconnectionstringhere");
                var sqlCommand = new DbCommand(sqlConnection, "INSERT");
                sqlCommand.Execute();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("DbCommand - SqlConnection : Null Argument Exception");
            }

            try
            {
                var oracleConnection = new OracleConnection("someconnectionstringhere");
                var sqlCommand = new DbCommand(oracleConnection, "UPDATE");
                sqlCommand.Execute();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("DbCommand - OracleConnection : Null Argument Exception");
            }
        }
    }
}
