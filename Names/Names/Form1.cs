namespace Names
{
    public partial class Names : Form
    {
        public Names()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }
    }
}
