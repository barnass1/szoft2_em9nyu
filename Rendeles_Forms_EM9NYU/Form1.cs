namespace Rendeles_Forms_EM9NYU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            termekKategoriaForm termekKategoriaForm = new termekKategoriaForm();
            termekKategoriaForm.ShowDialog();
        }
    }
}