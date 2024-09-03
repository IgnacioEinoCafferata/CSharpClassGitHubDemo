namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Hello world (CHANGED2)";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = !lblStatus.Visible;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            //THIS IS A CHANGE
        }
    }
}
