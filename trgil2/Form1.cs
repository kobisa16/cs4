namespace trgil2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewForm mdiChild = new ViewForm();
            mdiChild.MdiParent = this;
            mdiChild.Show();
        }

        private void addAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm modalForm = new AddForm();
            modalForm.ShowDialog();
        }
    }
}