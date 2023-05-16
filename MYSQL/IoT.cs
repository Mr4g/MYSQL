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


namespace MYSQL
{
    public partial class IoT : Form
    {

        public IoT()
        { 
            
            InitializeComponent(); 
        
        
        }


        public ChromiumWebBrowser browser;

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
            using (var plc = new Plc(CpuType.S71200, "192.168.0.2", 0, 1))
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
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string query = "insert into test(Kolumna_1,Kolumna_2) values(" + db1IntVariable + ",18)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

            }
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
            }
        }

        private void machine_Click(object sender, EventArgs e)
        {

        }


        private void conectiongif_Click(object sender, EventArgs e)
        {
            
        }



        private void sap_Click(object sender, EventArgs e)
        {
            {
                string newUrl = "https://me.sap.com/";

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

        private void webWindow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
