using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace SpitalCRUD
{
    public partial class CreateDataForm : Form
    {
        public CreateDataForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertPatientForm_InsertBtn_Click(object sender, EventArgs e)
        {
            try {
                string lastName = InsertPatientForm_LastNameInput.Text;
                string firstName = InsertPatientForm_FirstNameInput.Text;
                string address = InsertPatientForm_AddressInput.Text;

                if (lastName.Length < 3)
                {
                    throw new Exception("Introduceti numele pacientului! (marimea minima: 3 caractere)");
                }

                if (firstName.Length < 3) {
                    throw new Exception("Introduceti prenumele pacientului! (marimea minima: 3 caractere)");
                }

                DialogResult confirmModal = MessageBox.Show(
                    $"Datele pacientului:\nNume - {lastName}\nPrenume - {firstName}\nAdresa - {address}\n\nConfirmati inserarea datelor?",
                    "Inserarea datelor",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmModal == DialogResult.Yes)
                {
                    try
                    {
                        using (var dbConn = Database.GetConnection())
                        {
                            dbConn.Open();
                            var dbCmd = new NpgsqlCommand(
                                "INSERT INTO public.pacienti (nume, prenume, adresa) VALUES (@nume, @prenume, @adresa)",
                                dbConn
                            );
                            dbCmd.Parameters.AddWithValue("nume", lastName);
                            dbCmd.Parameters.AddWithValue("prenume", firstName);
                            dbCmd.Parameters.AddWithValue("adresa", address);
                            dbCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show(
                            "Operațiune reusita!",
                            "Inserarea datelor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex) {
                        MessageBox.Show(
                            $"Greseala in efectuarea operatiunii! Eroare: {ex.Message}",
                            "Inserarea datelor",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    
                }
                else {
                    MessageBox.Show(
                        "Operațiune anulată.",
                        "Inserarea datelor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Eroare de insertie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
