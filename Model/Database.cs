using System;
using ADOX;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;


// Ref https://support.microsoft.com/en-au/help/317881/how-to-create-an-access-database-by-using-adox-and-visual-c-net
// ADO.NET code example
// ref: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ado-net-code-examples#oledb

namespace Ass3_11670527_Saman.Model
{
  static  class Database
    {
        // static string currentDir = System.Environment.CurrentDirectory;
        internal static string dbFolder = "E:\\0work\\CSHARP\\Ass3_11670527_Saman\\bin\\";
        static OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" +
                   "Data Source=" + dbFolder  + "BurgerDB.mdb; Jet OLEDB:Engine Type=5");

        // Insert order item to database

        public static void InsertOrderItem( string itemName, string itemType, double baseCost, int quantity)
        {
            OleDbCommand cmd1;
           
            string cmdString = " INSERT INTO OrderItem (Name,  TypeName, BaseCost, Quantity) VALUES " +
                "( @itemName, @itemType, @baseCost, @quantity  )";
            cmd1 = new OleDbCommand(cmdString, conn);

            cmd1.Parameters.Add("@itemName", OleDbType.VarChar);
            cmd1.Parameters.Add("@itemType", OleDbType.VarChar);
            cmd1.Parameters.Add("@baseCost", OleDbType.Decimal);
            cmd1.Parameters.Add("@quantity", OleDbType.Integer);

            cmd1.Parameters["@itemName"].Value = itemName;
            cmd1.Parameters["@itemType"].Value = itemType;
            cmd1.Parameters["@baseCost"].Value = baseCost;
            cmd1.Parameters["@quantity"].Value = quantity;


            conn.Open();
            int rowsAffected = 0;

            try         // Insert data to table 
            {
                rowsAffected = cmd1.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " rows inserted ");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }  // end InsertOrderItem


        public static void  ConstructDatabase()
        {
            // Microsoft advise that ADOX class is not tested. It is used here only to create a database
            ADOX.Catalog cat = new ADOX.Catalog();



            // Create Database if it does not exists
            if (!File.Exists(dbFolder + "BurgerDB.mdb"))
            {
                cat.Create("Provider=Microsoft.Jet.OLEDB.4.0;" +
                   "Data Source=" + dbFolder + "BurgerDB.mdb;" +
                   "Jet OLEDB:Engine Type=5");

                MessageBox.Show("Database Created Successfully");
            }
            else
            {
                MessageBox.Show("Database already exists at " + dbFolder);
            }

            // Create tables 



            conn.Open();

            // Do not use possible SQL keywords in table names, field names.
            //   OleDbCommand cmd1 = new OleDbCommand("CREATE TABLE test1 (Name varchar(50), Quantity integer)", conn);  // works
            string cmdString = " CREATE TABLE OrderItem (Name varchar(50),  TypeName varchar(50), ISize varchar(10), BaseCost decimal, Quantity int)"; //  +

            OleDbCommand cmd1 = new OleDbCommand(cmdString, conn);

            try         // Ceeate the database table if it does not exist 
            {
                // Now lets execute the SQL ;D
                cmd1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // Insert data to table 

            // InsertOrderItem(conn, out cmdString, out cmd1);

            conn.Close();
            cat = null;
        }  // end of ConstructDatabase

    }
}
