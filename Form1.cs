namespace DificuldadeClique
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi");

            MessageBox.Show(
                "Você quer que eu pare de te incomodar?",
                "Eu sou o titulo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );
        }

        private void btnNao_MouseEnter(object sender, EventArgs e)
        {
            int largura_tela = this.ClientSize.Width; // Largura da tela
            int altura_tela = this.ClientSize.Height; // Altura da tela

            int x = random.Next(0, largura_tela - btnNao.Width);
            int y = random.Next(0, altura_tela - btnNao.Height);

            // Move o botão
            btnNao.Location = new Point(x, y);
        }
    }
}
