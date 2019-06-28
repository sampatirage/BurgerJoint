using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SQLLiteconsole
{
    class CLProgram
    {
        private static void NotMain (string[] args)
        {
            // Source: http://adodotnetsqlite.sourceforge.net/documentation/csharp_example.php
            // Sample will only work once since it cannot handle the case when database is already created
            // Locate the file 'database.db' in bin folder and delete if you want to run more than once

            // [snip] - As C# is purely object-oriented the following lines must be put into a class:

            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn = null;          // Database Connection Object
            SQLiteCommand sqlite_cmd;             // Database Command Object
            // SQLiteDataReader sqlite_datareader;  // Data Reader Object

            // create a new database connection:
            if (File.Exists("database.sqlite"))
            {
                sqlite_conn = new SQLiteConnection("Data Source=database.sqlite;Version=3;New=True;Compress=True;");
            }
            else
            {
                Console.Write("\n Database file doenot exist \n");
            }

            // open the connection:
            if (sqlite_conn != null)
            {
                sqlite_conn.Open();
            }

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            try         // Ceeate the database table if it does not exist 
            {
                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = "CREATE TABLE test (id integer primary key, text varchar(100));";
                // Now lets execute the SQL ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.Write("\n Looks like database table already exits \n");
            }

            // find the max of ID -
            sqlite_cmd.CommandText = "SELECT MAX(ID) FROM test ";
            // And execute this again ;D
            int maxID = 1;
            try  // if there are no rows it will throw error.
            {
               maxID = Convert.ToInt32( sqlite_cmd.ExecuteScalar()) ;
                sqlite_cmd.ExecuteReader().Close();
            }
            catch
            {
            }


            Console.Write($"\n Max ID ={maxID}\n");

            // insert line to database
            InsertLineToSQLLite(sqlite_conn, maxID);
            // show data
            ShowDataSQLLite(sqlite_conn);

            Console.Write("\n SQL lite test");
            Console.ReadKey();
        }

        private static void InsertLineToSQLLite(SQLiteConnection sqlite_conn, int maxID )
        {
           
            SQLiteCommand sqlite_cmd = new SQLiteCommand();             // Database Command Object
             sqlite_cmd.Connection = sqlite_conn;
             sqlite_cmd.CommandType = System.Data.CommandType.Text;         
            // Lets insert something into our new table:
            sqlite_cmd.CommandText = "INSERT INTO test (id, text) VALUES (" + (maxID+1 )+ ", 'Data Text ');";

            // And execute this again ;D
            sqlite_cmd.ExecuteNonQuery();
        }

        private static void ShowDataSQLLite(SQLiteConnection sqlite_conn)
        {

            SQLiteCommand sqlite_cmd = new SQLiteCommand();             // Database Command Object
            sqlite_cmd.Connection = sqlite_conn;
            sqlite_cmd.CommandType = System.Data.CommandType.Text;
            // Lets insert something into our new table:
            sqlite_cmd.CommandText = "SELECT * FROM test";


            // Now the SQLiteCommand object can give us a DataReader-Object:
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                //System.Console.WriteLine("DEBUG Output: '" + sqlite_datareader["text"] + "'");

                object idReader = sqlite_datareader.GetValue(0);
                string textReader = sqlite_datareader.GetString(1);

                Console.WriteLine(idReader + " '" + textReader + "' " + "\n");
            }

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
        }


    }
}
