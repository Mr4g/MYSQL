using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using Opc.Ua;
using Opc.Ua.Configuration;
using MySql.Data.MySqlClient;
using Opc.Ua.Client;
using System.Threading;

namespace MYSQL
{
    class Program
    {

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            {
                Thread thread = new Thread(DoSomething);
                thread.Start();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Application.Run(new IoT());
              

            }

        }

        public static void DoSomething()
        {
            // Kod, który ma być wykonany w innym wątku

            MySQL mySQL = new MySQL();
            mySQL.MySQLWrite();
        }
    }

}
