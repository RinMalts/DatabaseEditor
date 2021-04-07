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
            int kod = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string surname = textBox3.Text;
            string position = textBox4.Text;
            string query = "INSERT INTO Сотрудники ([Код сотрудника], Имя, Фамилия, Должность) VALUES (" + kod + " , '" + name + "' , '" + surname + "' , '" + position + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике добавлены.");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox7.Text);
            string query = "DELETE FROM Сотрудники WHERE [Код сотрудника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике удалены");
            textBox7.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.firmBDDataSet.Сотрудники);     
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int kod = Convert.ToInt32(textBox5.Text);
            string query = "UPDATE Сотрудники SET Должность = '" + textBox6.Text + "' WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность изменена");
            textBox6.Clear();
            textBox6.Clear();
        }

        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show(null);
        }
    }
}
