namespace moon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                MessageBox.Show("bbb");
                MessageBox.Show("2.0");
            }
            
        }
    }
}