namespace SpitalCRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            createDataBtn.Click += createDataBtn_Click;
            createDataBtnIco.Click += createDataBtn_Click;
            createDataBtnLabel.Click += createDataBtn_Click;

            readDataBtn.Click += readDataBtn_Click;
            readDataBtnIco.Click += readDataBtn_Click;
            readDataBtnLabel.Click += readDataBtn_Click;

            updateDataBtn.Click += updateDataBtn_Click;
            updateDataBtnIco.Click += updateDataBtn_Click;
            updateDataBtnLabel.Click += updateDataBtn_Click;

            deleteDataBtn.Click += deleteDataBtn_Click;
            deleteDataBtnIco.Click += deleteDataBtn_Click;
            deleteDataBtnLabel.Click += deleteDataBtn_Click;
        }

        private void createDataBtn_Click(object sender, EventArgs e)
        {
            CreateDataForm createDataForm = new CreateDataForm();
            createDataForm.ShowDialog();
        }

        private void readDataBtn_Click(object sender, EventArgs e)
        {
            ReadDataForm readDataForm = new ReadDataForm();
            readDataForm.ShowDialog();
        }

        private void updateDataBtn_Click(object sender, EventArgs e)
        {
            UpdateDataForm updateDataForm = new UpdateDataForm();
            updateDataForm.ShowDialog();
        }

        private void deleteDataBtn_Click(object sender, EventArgs e)
        {
            DeleteDataForm deleteDataForm = new DeleteDataForm();
            deleteDataForm.ShowDialog();
        }
    }
}
