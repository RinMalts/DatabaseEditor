using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace App1._2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {   
        //database connection
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myBDDataSet1.Сотрудники' table. You can move, or remove it, as needed.
            this.сотрудникиTableAdapter1.Fill(this.myBDDataSet1.Сотрудники);

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["App1.2"].ConnectionString);

            sqlConnection.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.Close();
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
            SqlCommand command = new SqlCommand(query, sqlConnection);
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
            SqlCommand command = new SqlCommand(query, sqlConnection);
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
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Должность изменена");
            textKodChange.Clear();
            textPositionChange.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.сотрудникиTableAdapter1.Fill(this.myBDDataSet1.Сотрудники);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
