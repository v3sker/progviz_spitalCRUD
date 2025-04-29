using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SpitalCRUD
{
    public partial class ReadDataForm : Form
    {
        public ReadDataForm()
        {
            InitializeComponent();
            QueryPatients();
        }

        private void QueryPatients()
        {
            try
            {
                using (var dbConn = Database.GetConnection())
                {
                    dbConn.Open();
                    string query = "SELECT * FROM public.pacienti WHERE 1=1";
                    
                    string id = IdInput.Text;
                    string lastName = LastNameInput.Text;
                    string firstName = FirstNameInput.Text;

                    if (!string.IsNullOrWhiteSpace(id) && id != "0")
                        query += " AND id = @id";
                    if (!string.IsNullOrWhiteSpace(lastName))
                        query += " AND nume ILIKE @nume";
                    if (!string.IsNullOrWhiteSpace(firstName))
                        query += " AND prenume ILIKE @prenume";

                    using (var cmd = new NpgsqlCommand(query, dbConn))
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        if (!string.IsNullOrWhiteSpace(id))
                            cmd.Parameters.AddWithValue("id", int.Parse(id));
                        if (!string.IsNullOrWhiteSpace(lastName))
                            cmd.Parameters.AddWithValue("nume", lastName);
                        if (!string.IsNullOrWhiteSpace(firstName))
                            cmd.Parameters.AddWithValue("prenume", firstName);

                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        ReadPatientsDataGrid.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Eroare: {ex.Message}",
                    "Citirea datelor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QueryPatients();
        }
    }
}
