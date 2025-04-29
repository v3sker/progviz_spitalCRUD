namespace SpitalCRUD
{
    partial class CreateDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            mainFormTitle = new Label();
            label1 = new Label();
            logo = new PictureBox();
            InsertTabgroup = new TabControl();
            InsertTabgroup_PatientTab = new TabPage();
            InsertPatientForm_AddressInput = new TextBox();
            InsertPatientForm_AddressLabel = new Label();
            InsertPatientForm_FirstNameInput = new TextBox();
            InsertPatientForm_FirstNameLabel = new Label();
            InsertPatientForm_LastNameInput = new TextBox();
            InsertPatientForm_LastNameLabel = new Label();
            InsertPatientForm_InsertBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            InsertTabgroup.SuspendLayout();
            InsertTabgroup_PatientTab.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(mainFormTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 79);
            panel1.TabIndex = 1;
            // 
            // mainFormTitle
            // 
            mainFormTitle.AutoSize = true;
            mainFormTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mainFormTitle.Location = new Point(75, 7);
            mainFormTitle.Name = "mainFormTitle";
            mainFormTitle.Size = new Size(519, 45);
            mainFormTitle.TabIndex = 1;
            mainFormTitle.Text = "Instituții Medico-Sanitare Publice";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(81, 46);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 2;
            label1.Text = "a Republicii Moldova";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(17, 14);
            logo.Name = "logo";
            logo.Size = new Size(52, 52);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // InsertTabgroup
            // 
            InsertTabgroup.Controls.Add(InsertTabgroup_PatientTab);
            InsertTabgroup.Location = new Point(17, 95);
            InsertTabgroup.Name = "InsertTabgroup";
            InsertTabgroup.SelectedIndex = 0;
            InsertTabgroup.Size = new Size(659, 207);
            InsertTabgroup.TabIndex = 2;
            // 
            // InsertTabgroup_PatientTab
            // 
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_AddressInput);
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_AddressLabel);
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_FirstNameInput);
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_FirstNameLabel);
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_LastNameInput);
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_LastNameLabel);
            InsertTabgroup_PatientTab.Controls.Add(InsertPatientForm_InsertBtn);
            InsertTabgroup_PatientTab.Location = new Point(4, 24);
            InsertTabgroup_PatientTab.Name = "InsertTabgroup_PatientTab";
            InsertTabgroup_PatientTab.Padding = new Padding(3);
            InsertTabgroup_PatientTab.Size = new Size(651, 179);
            InsertTabgroup_PatientTab.TabIndex = 0;
            InsertTabgroup_PatientTab.Text = "Pacient";
            InsertTabgroup_PatientTab.UseVisualStyleBackColor = true;
            // 
            // InsertPatientForm_AddressInput
            // 
            InsertPatientForm_AddressInput.Location = new Point(15, 85);
            InsertPatientForm_AddressInput.Name = "InsertPatientForm_AddressInput";
            InsertPatientForm_AddressInput.Size = new Size(323, 23);
            InsertPatientForm_AddressInput.TabIndex = 6;
            // 
            // InsertPatientForm_AddressLabel
            // 
            InsertPatientForm_AddressLabel.AutoSize = true;
            InsertPatientForm_AddressLabel.Location = new Point(15, 67);
            InsertPatientForm_AddressLabel.Name = "InsertPatientForm_AddressLabel";
            InsertPatientForm_AddressLabel.Size = new Size(43, 15);
            InsertPatientForm_AddressLabel.TabIndex = 5;
            InsertPatientForm_AddressLabel.Text = "Adresa";
            // 
            // InsertPatientForm_FirstNameInput
            // 
            InsertPatientForm_FirstNameInput.Location = new Point(185, 32);
            InsertPatientForm_FirstNameInput.Name = "InsertPatientForm_FirstNameInput";
            InsertPatientForm_FirstNameInput.Size = new Size(153, 23);
            InsertPatientForm_FirstNameInput.TabIndex = 4;
            // 
            // InsertPatientForm_FirstNameLabel
            // 
            InsertPatientForm_FirstNameLabel.AutoSize = true;
            InsertPatientForm_FirstNameLabel.Location = new Point(185, 14);
            InsertPatientForm_FirstNameLabel.Name = "InsertPatientForm_FirstNameLabel";
            InsertPatientForm_FirstNameLabel.Size = new Size(55, 15);
            InsertPatientForm_FirstNameLabel.TabIndex = 3;
            InsertPatientForm_FirstNameLabel.Text = "Prenume";
            // 
            // InsertPatientForm_LastNameInput
            // 
            InsertPatientForm_LastNameInput.Location = new Point(15, 32);
            InsertPatientForm_LastNameInput.Name = "InsertPatientForm_LastNameInput";
            InsertPatientForm_LastNameInput.Size = new Size(153, 23);
            InsertPatientForm_LastNameInput.TabIndex = 2;
            // 
            // InsertPatientForm_LastNameLabel
            // 
            InsertPatientForm_LastNameLabel.AutoSize = true;
            InsertPatientForm_LastNameLabel.Location = new Point(15, 14);
            InsertPatientForm_LastNameLabel.Name = "InsertPatientForm_LastNameLabel";
            InsertPatientForm_LastNameLabel.Size = new Size(40, 15);
            InsertPatientForm_LastNameLabel.TabIndex = 1;
            InsertPatientForm_LastNameLabel.Text = "Nume";
            // 
            // InsertPatientForm_InsertBtn
            // 
            InsertPatientForm_InsertBtn.Location = new Point(15, 127);
            InsertPatientForm_InsertBtn.Name = "InsertPatientForm_InsertBtn";
            InsertPatientForm_InsertBtn.Size = new Size(107, 35);
            InsertPatientForm_InsertBtn.TabIndex = 0;
            InsertPatientForm_InsertBtn.Text = "Inserare";
            InsertPatientForm_InsertBtn.UseVisualStyleBackColor = true;
            InsertPatientForm_InsertBtn.Click += InsertPatientForm_InsertBtn_Click;
            // 
            // CreateDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 316);
            Controls.Add(InsertTabgroup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inserare date | IMSP Rep. Moldova";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            InsertTabgroup.ResumeLayout(false);
            InsertTabgroup_PatientTab.ResumeLayout(false);
            InsertTabgroup_PatientTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label mainFormTitle;
        private Label label1;
        private PictureBox logo;
        private TabControl InsertTabgroup;
        private TabPage InsertTabgroup_PatientTab;
        private Button InsertPatientForm_InsertBtn;
        private TextBox InsertPatientForm_AddressInput;
        private Label InsertPatientForm_AddressLabel;
        private TextBox InsertPatientForm_FirstNameInput;
        private Label InsertPatientForm_FirstNameLabel;
        private TextBox InsertPatientForm_LastNameInput;
        private Label InsertPatientForm_LastNameLabel;
    }
}