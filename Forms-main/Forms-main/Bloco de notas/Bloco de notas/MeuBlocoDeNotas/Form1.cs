namespace MeuBlocoDeNotas
{
    public partial class Form1 : Form
    {
        string Filename { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog(this);
            Filename = ofd.FileName;

            if (result == DialogResult.OK)
            {

                string text = File.ReadAllText(Filename);
                textBox1.Text = text;
                label1.Text = Filename;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Filename, textBox1.Text);
        }


        private string encriptarr(string text)
        {
            string result = "";

            foreach (char c in text)

            {
                result += (char)(c + 4);

            }
            return result;

        }
        private string desencriptarr(string text)

        {

            string result = "";
            foreach (char c in text)
            {
                result += (char)(c - 4);
            }
            return result;
        }
        private void buttonEncriptar_Click(object sender, EventArgs e)
        {

            textBox1.Text = encriptarr(textBox1.Text);
        }
        private void buttonDesencriptar_Click(object sender, EventArgs e)
        {
            textBox1.Text = desencriptarr(textBox1.Text);

        }
    }
}