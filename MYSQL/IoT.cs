using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using S7.Net;
using CefSharp;
using CefSharp.WinForms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using MYSQL;



namespace MYSQL
{
    public partial class IoT : Form
    {
        
        public IoT()
        {

            InitializeComponent();
            IsMdiContainer = true;
            TableDataLoad();
            timer1.Start();
            

        }


        public ChromiumWebBrowser browser;
        public statusDataBaseForm newStatusDataBaseForm;

  

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=Root;database=test";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "Select * from test";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Kolumna_1:" + reader["Kolumna_1"]);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void chromiumHostControl1_Click(object sender, EventArgs e)
        {

        }

 


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splunk_Click(object sender, EventArgs e)
        {

            // zamknięcie DataBase jeśli jest otwarta
            if (newStatusDataBaseForm != null)
            {
                newStatusDataBaseForm.Close();
                newStatusDataBaseForm = null;
            }
            webWindow.Visible = true;
            string newUrl = "https://splunk05w05.viessmann.net:8000/en-GB/app/VI_W16/w16heliumtester1odu_kpi";

            if (browser == null)
            {
                browser = new ChromiumWebBrowser(newUrl);
                webWindow.Controls.Add(browser);
                conectiongif.Visible = true;
            }
            else
            {
                browser.Load(newUrl);
                conectiongif.Visible = true;
                statusMachine.Visible = false;
            }
        }

        private void machine_Click(object sender, EventArgs e)
        {

            statusMachine.Visible = true;

            if (machine == null)
            {

                statusMachine.Visible = false;
            }
            else
            {
                statusMachine.Visible = true;
            }
        }


        private void conectiongif_Click(object sender, EventArgs e)
        {

        }



        public void sap_Click(object sender, EventArgs e)
        {

            webWindow.Visible = true;


            if (newStatusDataBaseForm != null)
            {
                newStatusDataBaseForm.Close();
                newStatusDataBaseForm = null;
            }



            {
                string newUrl = "http://otw0039w05.viessmann.iotdmz:51300/manufacturing";

                if (browser == null)
                {
                    browser = new ChromiumWebBrowser(newUrl);
                    webWindow.Controls.Add(browser);
                    conectiongif.Visible = true;
                    webWindow.Visible = true;
                    statusMachine.Visible = false;

                }
                else
                {
                    browser.Load(newUrl);
                    conectiongif.Visible = true;
                    statusMachine.Visible = false;


                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void sapApp_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("saplogon.exe");

            Thread.Sleep(500);
            p.WaitForInputIdle();
            SetParent(p.MainWindowHandle, this.Handle);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void webWindow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void statusMachine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Downtime_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string selectCountQuery = "SELECT COUNT(*) FROM hmi";
            MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
            int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            if (rowCount > 0)
            {

                bool valueToInsert = buttonState;
                // Nadpisz wartość 1 we wszystkich kolumnach w pierwszym wierszu
                string updateQuery = "UPDATE hmi SET DownTime = " + (valueToInsert ? "1" : "0") + " LIMIT 1";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                buttonState = !buttonState;


            }
            con.Close();
        }

        public void DataBase_Click(object sender, EventArgs e)
        {
            newStatusDataBaseForm = new statusDataBaseForm();
            newStatusDataBaseForm.Show();
            newStatusDataBaseForm.MdiParent = this; // Ustawienie głównego okna jako rodzica MDI
            newStatusDataBaseForm.BringToFront(); // Przesunięcie okna na wierzch
            statusMachine.Visible = false;
            webWindow.Visible = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {



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



        void TableDataLoad()
        {



            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();



            // Pobierz dane i ustaw źródło danych w DataGridView
            string selectQuery = "SELECT DownTime, Setup, Maintenance, Personel, OthersLogistic, NOK FROM hmi";
            MySqlCommand selectCmd = new MySqlCommand(selectQuery, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectCmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            con.Close();

        }

        private void Mintenance_Click(object sender, EventArgs e)
        {

        }
        private bool buttonState = false;
        public void Setup_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string selectCountQuery = "SELECT COUNT(*) FROM hmi";
            MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
            int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            if (rowCount > 0)
            {

                bool valueToInsert = buttonState;
                // Nadpisz wartość 1 we wszystkich kolumnach w pierwszym wierszu
                string updateQuery = "UPDATE hmi SET Setup = " + (valueToInsert ? "1" : "0") + " LIMIT 1";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                buttonState = !buttonState;


            }
            con.Close();
        }
        private void NOK_Click(object sender, EventArgs e)
        {

            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string selectCountQuery = "SELECT COUNT(*) FROM hmi";
            MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
            int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            if (rowCount > 0)
            {

                bool valueToInsert = buttonState;
                // Nadpisz wartość 1 we wszystkich kolumnach w pierwszym wierszu
                string updateQuery = "UPDATE hmi SET NOK = " + (valueToInsert ? "1" : "0") + " LIMIT 1";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                buttonState = !buttonState;


            }
            con.Close();

        }

        private void Maintenance_Click(object sender, EventArgs e)
        {

            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string selectCountQuery = "SELECT COUNT(*) FROM hmi";
            MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
            int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            if (rowCount > 0)
            {

                bool valueToInsert = buttonState;
                // Nadpisz wartość 1 we wszystkich kolumnach w pierwszym wierszu
                string updateQuery = "UPDATE hmi SET Maintenance = " + (valueToInsert ? "1" : "0") + " LIMIT 1";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                buttonState = !buttonState;


            }
            con.Close();

        }


        private void OthersLogistic_Click(object sender, EventArgs e)
        {

            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string selectCountQuery = "SELECT COUNT(*) FROM hmi";
            MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
            int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            if (rowCount > 0)
            {

                bool valueToInsert = buttonState;
                // Nadpisz wartość 1 we wszystkich kolumnach w pierwszym wierszu
                string updateQuery = "UPDATE hmi SET OthersLogistic = " + (valueToInsert ? "1" : "0") + " LIMIT 1";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                buttonState = !buttonState;


            }
            con.Close();

        }

        private void Personel_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=Root;database=test";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            string selectCountQuery = "SELECT COUNT(*) FROM hmi";
            MySqlCommand selectCountCmd = new MySqlCommand(selectCountQuery, con);
            int rowCount = Convert.ToInt32(selectCountCmd.ExecuteScalar());

            if (rowCount > 0)
            {

                bool valueToInsert = buttonState;
                // Nadpisz wartość 1 we wszystkich kolumnach w pierwszym wierszu
                string updateQuery = "UPDATE hmi SET Personel = " + (valueToInsert ? "1" : "0") + " LIMIT 1";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                buttonState = !buttonState;


            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    } 
}

