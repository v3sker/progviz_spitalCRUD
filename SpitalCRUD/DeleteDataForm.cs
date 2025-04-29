using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpitalCRUD
{
    public partial class DeleteDataForm : Form
    {
        public DeleteDataForm()
        {
            InitializeComponent();

            DeletePatientForm_IdInput.KeyPress += DeletePatient_IdInput_KeyPress;
        }

        private void InsertPatientForm_InsertBtn_Click(object sender, EventArgs e)
        {
            try {
                string searchBy = DeletePatientForm_SearchByCombobox.Text;

                if (searchBy == "ID")
                {
                    string id = DeletePatientForm_IdInput.Text;

                    using (var dbConn = Database.GetConnection()) {
                        dbConn.Open();
                        var selectCmd = new NpgsqlCommand(
                            "SELECT id, nume, prenume, adresa FROM public.pacienti WHERE id = @id", dbConn
                        );
                        selectCmd.Parameters.AddWithValue("id", int.Parse(id));

                        var reader = selectCmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DialogResult confirmModal = MessageBox.Show(
                                $"Datele pacientului spre stergere:" +
                                $"\nID - {reader.GetInt16(0)}" +
                                $"\nNume - {reader.GetString(1)}" +
                                $"\nPrenume - {reader.GetString(2)}" +
                                $"\nAdresa - {reader.GetString(3)}" +
                                $"\n\nConfirmati stergerea?",
                                "Stergerea datelor",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (confirmModal == DialogResult.Yes)
                            {
                                try
                                {
                                    using (var secondDbConn = Database.GetConnection()) { 
                                        secondDbConn.Open();
                                        var deleteCmd = new NpgsqlCommand(
                                            "DELETE FROM public.pacienti WHERE id = @id",
                                            secondDbConn
                                        );
                                        deleteCmd.Parameters.AddWithValue("id", int.Parse(id));
                                        deleteCmd.ExecuteNonQuery();

                                        MessageBox.Show(
                                            "Operațiune reusita!",
                                            "Stergerea datelor",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information
                                        );
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(
                                        $"Greseala in efectuarea operatiunii! Eroare: {ex.Message}",
                                        "Stergerea datelor",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                }

                            }
                        }
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(
                    $"Eroare: {ex.Message}", 
                    "Stergerea datelor",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            
        }

        private void DeletePatientForm_SearchByCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeletePatientForm_SearchByCombobox.Text == "ID")
            {
                DeletePatientForm_IdInput.Enabled = true;
                DeletePatientForm_LastNameInput.Enabled = false;
                DeletePatientForm_LastNameInput.Text = "";
                DeletePatientForm_FirstNameInput.Enabled = false;
                DeletePatientForm_FirstNameInput.Text = "";
            }
            else if (DeletePatientForm_SearchByCombobox.Text == "Nume, prenume")
            {
                DeletePatientForm_IdInput.Enabled = false;
                DeletePatientForm_IdInput.Text = "";
                DeletePatientForm_LastNameInput.Enabled = true;
                DeletePatientForm_FirstNameInput.Enabled = true;
            }
            else
            {
                DeletePatientForm_IdInput.Enabled = false;
                DeletePatientForm_IdInput.Text = "";
                DeletePatientForm_LastNameInput.Enabled = false;
                DeletePatientForm_LastNameInput.Text = "";
                DeletePatientForm_FirstNameInput.Enabled = false;
                DeletePatientForm_FirstNameInput.Text = "";
            }
        }

        private void DeleteDataForm_Load(object sender, EventArgs e)
        {
            DeletePatientForm_IdInput.Enabled = false;
            DeletePatientForm_LastNameInput.Enabled = false;
            DeletePatientForm_FirstNameInput.Enabled = false;
        }

        private void DeletePatient_IdInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(DeletePatientForm_IdInput.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                DeletePatientForm_IdInput.Text = DeletePatientForm_IdInput.Text.Remove(
                    DeletePatientForm_IdInput.Text.Length - 1
                );
            }
        }
    }
}
