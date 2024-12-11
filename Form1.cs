namespace Eclipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(richTextBox1.Text);
        }

        private void Kill_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.KillRoblox();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            ForlornApi.Api.Inject();
        }

        private void Clo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
