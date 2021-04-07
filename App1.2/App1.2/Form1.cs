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
    public partial class Form1 : MetroFramework.Forms.MetroForm
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
            if (!int.TryParse(textKodAdd.Text, out int kod))
            {
                MessageBox.Show("Введите код");
                return;
            }
            string name = textNameAdd.Text;
            string surname = textSurnameAdd.Text;
            string position = textPositionAdd.Text;
            string query = "INSERT INTO Сотрудники ([Код сотрудника], Имя, Фамилия, Должность) VALUES (" + kod + " , '" + name + "' , '" + surname + "' , '" + position + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике добавлены.");
            textKodAdd.Clear();
            textNameAdd.Clear();
            textSurnameAdd.Clear();
            textPositionAdd.Clear();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textKodDelete.Text, out int kod))
            {
                MessageBox.Show("Введите код");
                return;
            }
            string query = "DELETE FROM Сотрудники WHERE [Код сотрудника] =" + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Данные о сотруднике удалены");
            textKodDelete.Clear();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textKodChange.Text, out int kod))
            {
                MessageBox.Show("Введите код");
                return;
            }
            string query = "UPDATE Сотрудники SET Должность = '" + textPositionChange.Text + "' WHERE [Код сотрудника] = " + kod;
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность изменена");
            textKodChange.Clear();
            textPositionChange.Clear();
        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter.Fill(this.firmBDDataSet.Сотрудники);     
        }
        private void buttonPosition_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
