namespace MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // Hide other userControls
            userControl21.Hide();
            userControl31.Hide();
            // Show current userControl
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();

            userControl21.Show();
            userControl21.BringToFront();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();

            userControl31.Show();
            userControl31.BringToFront();
        }
    }
}
