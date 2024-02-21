namespace MyOldWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = button1.DialogResult;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = button2.DialogResult;

        }
    }
}
