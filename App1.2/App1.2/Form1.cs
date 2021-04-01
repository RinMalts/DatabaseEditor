using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace App1._2
{
    public partial class Form1 : MetroForm
    {   
        //database connection
        public static string connectString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = FirmBD.mdb"; 
        private OleDbConnection myConnection;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmBDDataSet.Сотрудники' table. You can move, or remove it, as needed.
            this.сотрудникиTableAdapter.Fill(this.firmBDDataSet.Сотрудники);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Сотрудники SET";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQueryAsync(); // added ..Async

        }
    }
}
