using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection
{
    public partial class Form1 : Form
    { //"Server=localhost; Database=Northwind; Integrated Security=true;"
        private SqlConnection conn = new SqlConnection("Server=SHIZOFREN\\SQLEXPRESS; Database=Northwind; Integrated Security=true;");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                btn_Con.Text = "Disconnect";
                lblConnection.Text = "Connection opened";

             }
            else
            {
                conn.Close();
                btn_Con.Text = "Connect";
                lblConnection.Text = "Connection closed";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblConnection_Click(object sender, EventArgs e)
        {

        }
    }
}
