using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using Opc.Ua;

namespace MYSQL
{
    class OPCClient
    {

        public void OPCClient1()
        {
            // Generate a client application
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Client;

            // Load the configuration file
            application.LoadApplicationConfiguration(@"./ConsoleReferenceClient.Config.xml", false).Wait();

            ApplicationConfiguration m_configuration = application.ApplicationConfiguration;

            // Connect to a server

            // Get the endpoint by connecting to server's discovery endpoint.
            // Try to find the first endopint without security.
            EndpointDescription endpointDescription = CoreClientUtils.SelectEndpoint("opc.tcp://localhost:26543/OPCUAServer", false);

            EndpointConfiguration endpointConfiguration = EndpointConfiguration.Create(m_configuration);
            ConfiguredEndpoint endpoint = new ConfiguredEndpoint(null, endpointDescription, endpointConfiguration);

            // Create the session
            Session session = Session.Create(
                m_configuration,
                endpoint,
                false,
                false,
                m_configuration.ApplicationName,
                (uint)m_configuration.ClientConfiguration.DefaultSessionTimeout,
                new UserIdentity(),
                null).Result;

            //Połącz z mysql

            {
                string connectionString = "server=localhost;uid=root;pwd=Root;database=test";
                string sql = "Select Kolumna_2 from test limit 1";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            double Wartosc = Convert.ToDouble(reader["Kolumna_2"]);




                            // Read variable
                            Console.WriteLine(session.ReadValue(new NodeId(97, 2)));

                            //Write variable
                            WriteValueCollection nodesToWrite = new WriteValueCollection();

                            WriteValue intWriteVal = new WriteValue();
                            intWriteVal.NodeId = new NodeId(97, 2);
                            intWriteVal.AttributeId = Attributes.Value;
                            intWriteVal.Value = new DataValue();
                            intWriteVal.Value.Value = (double)Wartosc;
                            nodesToWrite.Add(intWriteVal);


                            StatusCodeCollection results = null;
                            DiagnosticInfoCollection diagnosticInfos;

                            // Call Write Service
                            session.Write(null,
                                          nodesToWrite,
                                          out results,
                                          out diagnosticInfos);

                            // Call method
                            IList<object> outputArguments = session.Call(new NodeId(96, 2), new NodeId(103, 2));

                            // Disconnect
                            session.Close();
                            session.Dispose();
                            // Zamknij połączenie z mysql
                        }

                        reader.Close();
                    }
                }
            }
        }
    }
}
