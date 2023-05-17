using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using S7.Net;


namespace MYSQL
{
    class MySQL
    {

        public void MySQLWrite()
        {
            
            while (true)
            {

                OPCClient Client = new OPCClient();
                Client.OPCClient1();


                using (var plc = new Plc(CpuType.S71200, "192.168.0.1", 0, 1))
                {
                    plc.Open();

                    bool db1Bool1 = (bool)plc.Read("DB1.DBX0.0");
                    Console.WriteLine("DB1.DBX0.0: " + db1Bool1);


                    bool db1Bool2 = (bool)plc.Read("DB1.DBX0.1");
                    Console.WriteLine("DB1.DBX0.1: " + db1Bool2);

                    var db1IntVariable = (ushort)plc.Read("DB1.DBW2.0");
                    Console.WriteLine("DB1.DBW2.0: " + db1IntVariable);

                    var db1RealVariable = ((uint)plc.Read("DB1.DBD4.0")).ConvertToFloat();
                    Console.WriteLine("DB1.DBD4.0: " + db1RealVariable);


                    var db1DintVariable = (uint)plc.Read("DB1.DBD8.0");
                    Console.WriteLine("DB1.DBD8.0: " + db1DintVariable);

                    var db1DwordVariable = (uint)plc.Read("DB1.DBD12.0");
                    Console.WriteLine("DB1.DBD12.0: " + db1DwordVariable);

                    var db1WordVariable = (ushort)plc.Read("DB1.DBW16.0");
                    Console.WriteLine("DB1.DBD16.0: " + db1WordVariable);



                    string connstring = "server=localhost;uid=root;pwd=Root;database=test";
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();

                    string deleteQuery = "DELETE FROM test WHERE Kolumna_1 BETWEEN 1 AND 10";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
                    deleteCmd.ExecuteNonQuery();

                    string insertQuery = "INSERT INTO test (Kolumna_1, Kolumna_2) VALUES (@Kolumna_1, @Kolumna_2)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@Kolumna_1", MySqlDbType.Int32);
                    insertCmd.Parameters.AddWithValue("@Kolumna_2", db1IntVariable);

                    for (int i = 1; i <= 10; i++)
                    {
                        insertCmd.Parameters["@Kolumna_1"].Value = i;
                        insertCmd.ExecuteNonQuery();
                    }

               

                    
                    con.Close();


                }
            }
        }
    }
}