namespace SpitalCRUD
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            mainFormTitle = new Label();
            logo = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            createDataBtn = new Panel();
            createDataBtnIco = new PictureBox();
            createDataBtnLabel = new Label();
            readDataBtn = new Panel();
            readDataBtnIco = new PictureBox();
            readDataBtnLabel = new Label();
            updateDataBtn = new Panel();
            updateDataBtnIco = new PictureBox();
            updateDataBtnLabel = new Label();
            deleteDataBtn = new Panel();
            deleteDataBtnIco = new PictureBox();
            deleteDataBtnLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            createDataBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)createDataBtnIco).BeginInit();
            readDataBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)readDataBtnIco).BeginInit();
            updateDataBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updateDataBtnIco).BeginInit();
            deleteDataBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deleteDataBtnIco).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(mainFormTitle);
            panel1.Controls.Add(logo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 79);
            panel1.TabIndex = 0;
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(createDataBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(readDataBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(updateDataBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(deleteDataBtn, 3, 0);
            tableLayoutPanel1.Location = new Point(15, 95);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(820, 167);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // createDataBtn
            // 
            createDataBtn.BackColor = Color.White;
            createDataBtn.Controls.Add(createDataBtnIco);
            createDataBtn.Controls.Add(createDataBtnLabel);
            createDataBtn.Cursor = Cursors.Hand;
            createDataBtn.Location = new Point(3, 3);
            createDataBtn.Name = "createDataBtn";
            createDataBtn.Size = new Size(199, 161);
            createDataBtn.TabIndex = 0;
            // 
            // createDataBtnIco
            // 
            createDataBtnIco.Image = Properties.Resources.create_patient;
            createDataBtnIco.Location = new Point(51, 16);
            createDataBtnIco.Name = "createDataBtnIco";
            createDataBtnIco.Size = new Size(93, 97);
            createDataBtnIco.SizeMode = PictureBoxSizeMode.StretchImage;
            createDataBtnIco.TabIndex = 1;
            createDataBtnIco.TabStop = false;
            // 
            // createDataBtnLabel
            // 
            createDataBtnLabel.AutoSize = true;
            createDataBtnLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            createDataBtnLabel.Location = new Point(29, 120);
            createDataBtnLabel.Name = "createDataBtnLabel";
            createDataBtnLabel.Size = new Size(138, 30);
            createDataBtnLabel.TabIndex = 0;
            createDataBtnLabel.Text = "Inserare date";
            // 
            // readDataBtn
            // 
            readDataBtn.BackColor = Color.White;
            readDataBtn.Controls.Add(readDataBtnIco);
            readDataBtn.Controls.Add(readDataBtnLabel);
            readDataBtn.Cursor = Cursors.Hand;
            readDataBtn.Location = new Point(208, 3);
            readDataBtn.Name = "readDataBtn";
            readDataBtn.Size = new Size(199, 161);
            readDataBtn.TabIndex = 1;
            // 
            // readDataBtnIco
            // 
            readDataBtnIco.Image = Properties.Resources.list_patient;
            readDataBtnIco.Location = new Point(37, 3);
            readDataBtnIco.Name = "readDataBtnIco";
            readDataBtnIco.Size = new Size(125, 121);
            readDataBtnIco.SizeMode = PictureBoxSizeMode.StretchImage;
            readDataBtnIco.TabIndex = 2;
            readDataBtnIco.TabStop = false;
            // 
            // readDataBtnLabel
            // 
            readDataBtnLabel.AutoSize = true;
            readDataBtnLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            readDataBtnLabel.Location = new Point(44, 120);
            readDataBtnLabel.Name = "readDataBtnLabel";
            readDataBtnLabel.Size = new Size(112, 30);
            readDataBtnLabel.TabIndex = 1;
            readDataBtnLabel.Text = "Citire date";
            // 
            // updateDataBtn
            // 
            updateDataBtn.BackColor = Color.White;
            updateDataBtn.Controls.Add(updateDataBtnIco);
            updateDataBtn.Controls.Add(updateDataBtnLabel);
            updateDataBtn.Cursor = Cursors.Hand;
            updateDataBtn.Location = new Point(413, 3);
            updateDataBtn.Name = "updateDataBtn";
            updateDataBtn.Size = new Size(199, 161);
            updateDataBtn.TabIndex = 2;
            // 
            // updateDataBtnIco
            // 
            updateDataBtnIco.Image = Properties.Resources.update_patient;
            updateDataBtnIco.Location = new Point(61, 27);
            updateDataBtnIco.Name = "updateDataBtnIco";
            updateDataBtnIco.Size = new Size(79, 79);
            updateDataBtnIco.SizeMode = PictureBoxSizeMode.StretchImage;
            updateDataBtnIco.TabIndex = 3;
            updateDataBtnIco.TabStop = false;
            // 
            // updateDataBtnLabel
            // 
            updateDataBtnLabel.AutoSize = true;
            updateDataBtnLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            updateDataBtnLabel.Location = new Point(17, 120);
            updateDataBtnLabel.Name = "updateDataBtnLabel";
            updateDataBtnLabel.Size = new Size(164, 30);
            updateDataBtnLabel.TabIndex = 2;
            updateDataBtnLabel.Text = "Modificare date";
            // 
            // deleteDataBtn
            // 
            deleteDataBtn.BackColor = Color.White;
            deleteDataBtn.Controls.Add(deleteDataBtnIco);
            deleteDataBtn.Controls.Add(deleteDataBtnLabel);
            deleteDataBtn.Cursor = Cursors.Hand;
            deleteDataBtn.Location = new Point(618, 3);
            deleteDataBtn.Name = "deleteDataBtn";
            deleteDataBtn.Size = new Size(199, 161);
            deleteDataBtn.TabIndex = 3;
            // 
            // deleteDataBtnIco
            // 
            deleteDataBtnIco.Image = Properties.Resources.delete_patient;
            deleteDataBtnIco.Location = new Point(61, 21);
            deleteDataBtnIco.Name = "deleteDataBtnIco";
            deleteDataBtnIco.Size = new Size(79, 90);
            deleteDataBtnIco.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteDataBtnIco.TabIndex = 4;
            deleteDataBtnIco.TabStop = false;
            // 
            // deleteDataBtnLabel
            // 
            deleteDataBtnLabel.AutoSize = true;
            deleteDataBtnLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteDataBtnLabel.Location = new Point(28, 120);
            deleteDataBtnLabel.Name = "deleteDataBtnLabel";
            deleteDataBtnLabel.Size = new Size(142, 30);
            deleteDataBtnLabel.TabIndex = 3;
            deleteDataBtnLabel.Text = "Stergere date";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 274);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu principal | IMSP Rep. Moldova";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            createDataBtn.ResumeLayout(false);
            createDataBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)createDataBtnIco).EndInit();
            readDataBtn.ResumeLayout(false);
            readDataBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)readDataBtnIco).EndInit();
            updateDataBtn.ResumeLayout(false);
            updateDataBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updateDataBtnIco).EndInit();
            deleteDataBtn.ResumeLayout(false);
            deleteDataBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deleteDataBtnIco).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox logo;
        private Label mainFormTitle;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel createDataBtn;
        private Panel readDataBtn;
        private Panel updateDataBtn;
        private Panel deleteDataBtn;
        private Label createDataBtnLabel;
        private Label readDataBtnLabel;
        private Label updateDataBtnLabel;
        private Label deleteDataBtnLabel;
        private PictureBox createDataBtnIco;
        private PictureBox readDataBtnIco;
        private PictureBox updateDataBtnIco;
        private PictureBox deleteDataBtnIco;
    }
}
