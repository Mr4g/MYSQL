using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MYSQL
{
    public partial class statusDataBaseForm : Form
    {
        public statusDataBaseForm()
        {
            InitializeComponent();
            TableDataLoad();
            timer1.Start();
        }
           void TableDataLoad()
        {
            
        

                string connstring = "server=localhost;uid=root;pwd=Root;database=test";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                // Pobierz liczbę wierszy
                string selectCountQuery = "SELECT COUNT(*) FROM test";
                MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
                int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            // Pobierz dane i ustaw źródło danych w DataGridView
            string selectQuery = "SELECT Kolumna_1, Kolumna_2 FROM test";
            MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            con.Close();

            }






            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        public virtual void RefreshDataSource()
        {
            TableDataLoad();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void statusDataBaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
