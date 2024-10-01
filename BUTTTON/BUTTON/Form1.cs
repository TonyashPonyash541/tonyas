namespace WinFormsApp2
{
    public partial class MyButtonApp : Form
    {
       

        public MyButtonApp()
        {
            InitializeComponent();
            Text = "Hello";
            this.BackColor = Color.DeepSkyBlue;
            this.Width = 450;
            this.Height = 400;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show(); 
        }
    }
}
