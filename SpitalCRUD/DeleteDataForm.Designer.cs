namespace SpitalCRUD
{
    partial class DeleteDataForm
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
            DeleteTabgroup = new TabControl();
            DeleteTabgroup_PatientTab = new TabPage();
            label2 = new Label();
            DeletePatientForm_FirstNameInput = new TextBox();
            DeletePatientForm_FirstNameLabel = new Label();
            DeletePatientForm_LastNameInput = new TextBox();
            DeletePatientForm_LastNameLabel = new Label();
            DeletePatientForm_SearchByCombobox = new ComboBox();
            DeletePatientForm_SearchByLabel = new Label();
            InsertPatientForm_InsertBtn = new Button();
            DeletePatientForm_IdInput = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            DeleteTabgroup.SuspendLayout();
            DeleteTabgroup_PatientTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeletePatientForm_IdInput).BeginInit();
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
            panel1.TabIndex = 3;
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
            // DeleteTabgroup
            // 
            DeleteTabgroup.Controls.Add(DeleteTabgroup_PatientTab);
            DeleteTabgroup.Location = new Point(17, 96);
            DeleteTabgroup.Name = "DeleteTabgroup";
            DeleteTabgroup.SelectedIndex = 0;
            DeleteTabgroup.Size = new Size(700, 202);
            DeleteTabgroup.TabIndex = 4;
            // 
            // DeleteTabgroup_PatientTab
            // 
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_IdInput);
            DeleteTabgroup_PatientTab.Controls.Add(label2);
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_FirstNameInput);
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_FirstNameLabel);
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_LastNameInput);
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_LastNameLabel);
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_SearchByCombobox);
            DeleteTabgroup_PatientTab.Controls.Add(DeletePatientForm_SearchByLabel);
            DeleteTabgroup_PatientTab.Controls.Add(InsertPatientForm_InsertBtn);
            DeleteTabgroup_PatientTab.Location = new Point(4, 24);
            DeleteTabgroup_PatientTab.Name = "DeleteTabgroup_PatientTab";
            DeleteTabgroup_PatientTab.Padding = new Padding(3);
            DeleteTabgroup_PatientTab.Size = new Size(692, 174);
            DeleteTabgroup_PatientTab.TabIndex = 0;
            DeleteTabgroup_PatientTab.Text = "Pacient";
            DeleteTabgroup_PatientTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // DeletePatientForm_FirstNameInput
            // 
            DeletePatientForm_FirstNameInput.Location = new Point(334, 86);
            DeletePatientForm_FirstNameInput.Name = "DeletePatientForm_FirstNameInput";
            DeletePatientForm_FirstNameInput.Size = new Size(153, 23);
            DeletePatientForm_FirstNameInput.TabIndex = 9;
            // 
            // DeletePatientForm_FirstNameLabel
            // 
            DeletePatientForm_FirstNameLabel.AutoSize = true;
            DeletePatientForm_FirstNameLabel.Location = new Point(334, 68);
            DeletePatientForm_FirstNameLabel.Name = "DeletePatientForm_FirstNameLabel";
            DeletePatientForm_FirstNameLabel.Size = new Size(55, 15);
            DeletePatientForm_FirstNameLabel.TabIndex = 8;
            DeletePatientForm_FirstNameLabel.Text = "Prenume";
            // 
            // DeletePatientForm_LastNameInput
            // 
            DeletePatientForm_LastNameInput.Location = new Point(164, 86);
            DeletePatientForm_LastNameInput.Name = "DeletePatientForm_LastNameInput";
            DeletePatientForm_LastNameInput.Size = new Size(153, 23);
            DeletePatientForm_LastNameInput.TabIndex = 7;
            // 
            // DeletePatientForm_LastNameLabel
            // 
            DeletePatientForm_LastNameLabel.AutoSize = true;
            DeletePatientForm_LastNameLabel.Location = new Point(164, 68);
            DeletePatientForm_LastNameLabel.Name = "DeletePatientForm_LastNameLabel";
            DeletePatientForm_LastNameLabel.Size = new Size(40, 15);
            DeletePatientForm_LastNameLabel.TabIndex = 6;
            DeletePatientForm_LastNameLabel.Text = "Nume";
            // 
            // DeletePatientForm_SearchByCombobox
            // 
            DeletePatientForm_SearchByCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeletePatientForm_SearchByCombobox.Items.AddRange(new object[] { "ID", "Nume, prenume" });
            DeletePatientForm_SearchByCombobox.Location = new Point(15, 31);
            DeletePatientForm_SearchByCombobox.Name = "DeletePatientForm_SearchByCombobox";
            DeletePatientForm_SearchByCombobox.Size = new Size(131, 23);
            DeletePatientForm_SearchByCombobox.TabIndex = 5;
            DeletePatientForm_SearchByCombobox.SelectedIndexChanged += DeletePatientForm_SearchByCombobox_SelectedIndexChanged;
            // 
            // DeletePatientForm_SearchByLabel
            // 
            DeletePatientForm_SearchByLabel.AutoSize = true;
            DeletePatientForm_SearchByLabel.Location = new Point(15, 13);
            DeletePatientForm_SearchByLabel.Name = "DeletePatientForm_SearchByLabel";
            DeletePatientForm_SearchByLabel.Size = new Size(78, 15);
            DeletePatientForm_SearchByLabel.TabIndex = 3;
            DeletePatientForm_SearchByLabel.Text = "Cautare dupa";
            // 
            // InsertPatientForm_InsertBtn
            // 
            InsertPatientForm_InsertBtn.Location = new Point(15, 124);
            InsertPatientForm_InsertBtn.Name = "InsertPatientForm_InsertBtn";
            InsertPatientForm_InsertBtn.Size = new Size(107, 35);
            InsertPatientForm_InsertBtn.TabIndex = 1;
            InsertPatientForm_InsertBtn.Text = "Stergere";
            InsertPatientForm_InsertBtn.UseVisualStyleBackColor = true;
            InsertPatientForm_InsertBtn.Click += InsertPatientForm_InsertBtn_Click;
            // 
            // DeletePatientForm_IdInput
            // 
            DeletePatientForm_IdInput.Location = new Point(15, 86);
            DeletePatientForm_IdInput.Name = "DeletePatientForm_IdInput";
            DeletePatientForm_IdInput.Size = new Size(131, 23);
            DeletePatientForm_IdInput.TabIndex = 11;
            // 
            // DeleteDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 310);
            Controls.Add(DeleteTabgroup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Stergere date | IMSP Rep. Moldova";
            Load += DeleteDataForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            DeleteTabgroup.ResumeLayout(false);
            DeleteTabgroup_PatientTab.ResumeLayout(false);
            DeleteTabgroup_PatientTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeletePatientForm_IdInput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label mainFormTitle;
        private Label label1;
        private PictureBox logo;
        private TabControl DeleteTabgroup;
        private TabPage DeleteTabgroup_PatientTab;
        private Button InsertPatientForm_InsertBtn;
        private ComboBox DeletePatientForm_SearchByCombobox;
        private Label DeletePatientForm_SearchByLabel;
        private Label label2;
        private TextBox DeletePatientForm_FirstNameInput;
        private Label DeletePatientForm_FirstNameLabel;
        private TextBox DeletePatientForm_LastNameInput;
        private Label DeletePatientForm_LastNameLabel;
        private NumericUpDown DeletePatientForm_IdInput;
    }
}