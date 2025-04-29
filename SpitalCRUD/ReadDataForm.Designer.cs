namespace SpitalCRUD
{
    partial class ReadDataForm
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
            ReadTabgroup = new TabControl();
            ReadTabgroup_PatientsTab = new TabPage();
            ReadBtn = new Button();
            IdInput = new NumericUpDown();
            ReadPatientForm_IdLabel = new Label();
            ReadPatientsDataGrid = new DataGridView();
            FirstNameInput = new TextBox();
            ReadPatientForm_LastNameLabel = new Label();
            ReadPatientForm_FirstNameLabel = new Label();
            LastNameInput = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ReadTabgroup.SuspendLayout();
            ReadTabgroup_PatientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IdInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReadPatientsDataGrid).BeginInit();
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
            panel1.TabIndex = 2;
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
            // ReadTabgroup
            // 
            ReadTabgroup.Controls.Add(ReadTabgroup_PatientsTab);
            ReadTabgroup.Location = new Point(17, 96);
            ReadTabgroup.Name = "ReadTabgroup";
            ReadTabgroup.SelectedIndex = 0;
            ReadTabgroup.Size = new Size(644, 358);
            ReadTabgroup.TabIndex = 3;
            // 
            // ReadTabgroup_PatientsTab
            // 
            ReadTabgroup_PatientsTab.Controls.Add(ReadBtn);
            ReadTabgroup_PatientsTab.Controls.Add(IdInput);
            ReadTabgroup_PatientsTab.Controls.Add(ReadPatientForm_IdLabel);
            ReadTabgroup_PatientsTab.Controls.Add(ReadPatientsDataGrid);
            ReadTabgroup_PatientsTab.Controls.Add(FirstNameInput);
            ReadTabgroup_PatientsTab.Controls.Add(ReadPatientForm_LastNameLabel);
            ReadTabgroup_PatientsTab.Controls.Add(ReadPatientForm_FirstNameLabel);
            ReadTabgroup_PatientsTab.Controls.Add(LastNameInput);
            ReadTabgroup_PatientsTab.Location = new Point(4, 24);
            ReadTabgroup_PatientsTab.Name = "ReadTabgroup_PatientsTab";
            ReadTabgroup_PatientsTab.Padding = new Padding(3);
            ReadTabgroup_PatientsTab.Size = new Size(636, 330);
            ReadTabgroup_PatientsTab.TabIndex = 0;
            ReadTabgroup_PatientsTab.Text = "Pacienti";
            ReadTabgroup_PatientsTab.UseVisualStyleBackColor = true;
            // 
            // ReadBtn
            // 
            ReadBtn.Location = new Point(498, 9);
            ReadBtn.Name = "ReadBtn";
            ReadBtn.Size = new Size(132, 41);
            ReadBtn.TabIndex = 18;
            ReadBtn.Text = "Cautare";
            ReadBtn.UseVisualStyleBackColor = true;
            ReadBtn.Click += button1_Click;
            // 
            // IdInput
            // 
            IdInput.Location = new Point(6, 27);
            IdInput.Name = "IdInput";
            IdInput.Size = new Size(131, 23);
            IdInput.TabIndex = 17;
            // 
            // ReadPatientForm_IdLabel
            // 
            ReadPatientForm_IdLabel.AutoSize = true;
            ReadPatientForm_IdLabel.Location = new Point(6, 9);
            ReadPatientForm_IdLabel.Name = "ReadPatientForm_IdLabel";
            ReadPatientForm_IdLabel.Size = new Size(18, 15);
            ReadPatientForm_IdLabel.TabIndex = 16;
            ReadPatientForm_IdLabel.Text = "ID";
            // 
            // ReadPatientsDataGrid
            // 
            ReadPatientsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReadPatientsDataGrid.Location = new Point(6, 67);
            ReadPatientsDataGrid.Name = "ReadPatientsDataGrid";
            ReadPatientsDataGrid.Size = new Size(624, 257);
            ReadPatientsDataGrid.TabIndex = 0;
            // 
            // FirstNameInput
            // 
            FirstNameInput.Location = new Point(325, 27);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(153, 23);
            FirstNameInput.TabIndex = 15;
            // 
            // ReadPatientForm_LastNameLabel
            // 
            ReadPatientForm_LastNameLabel.AutoSize = true;
            ReadPatientForm_LastNameLabel.Location = new Point(155, 9);
            ReadPatientForm_LastNameLabel.Name = "ReadPatientForm_LastNameLabel";
            ReadPatientForm_LastNameLabel.Size = new Size(40, 15);
            ReadPatientForm_LastNameLabel.TabIndex = 12;
            ReadPatientForm_LastNameLabel.Text = "Nume";
            // 
            // ReadPatientForm_FirstNameLabel
            // 
            ReadPatientForm_FirstNameLabel.AutoSize = true;
            ReadPatientForm_FirstNameLabel.Location = new Point(325, 9);
            ReadPatientForm_FirstNameLabel.Name = "ReadPatientForm_FirstNameLabel";
            ReadPatientForm_FirstNameLabel.Size = new Size(55, 15);
            ReadPatientForm_FirstNameLabel.TabIndex = 14;
            ReadPatientForm_FirstNameLabel.Text = "Prenume";
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(155, 27);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(153, 23);
            LastNameInput.TabIndex = 13;
            // 
            // ReadDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 469);
            Controls.Add(ReadTabgroup);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReadDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Citire date | IMSP Rep. Moldova";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ReadTabgroup.ResumeLayout(false);
            ReadTabgroup_PatientsTab.ResumeLayout(false);
            ReadTabgroup_PatientsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IdInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReadPatientsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label mainFormTitle;
        private Label label1;
        private PictureBox logo;
        private TabControl ReadTabgroup;
        private TabPage ReadTabgroup_PatientsTab;
        private DataGridView ReadPatientsDataGrid;
        private NumericUpDown IdInput;
        private Label ReadPatientForm_IdLabel;
        private TextBox FirstNameInput;
        private Label ReadPatientForm_LastNameLabel;
        private Label ReadPatientForm_FirstNameLabel;
        private TextBox LastNameInput;
        private Button ReadBtn;
    }
}