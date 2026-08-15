namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string caminho = Path.Combine(FileSystem.AppDataDirectory, "nota.txt");

        public MainPage()
        {
            InitializeComponent();
        }

        private void AoClicarlNoSalvar(object? sender, EventArgs e)
        {
            string conteudo = EditorAnotacao.Text;
            File.WriteAllText(caminho, conteudo);
        }

        private void AoClicarlNoApagar(object? sender, EventArgs e)
        {

        }

        private void AoClicarlNoCarregar(object? sender, EventArgs e)
        {

        }
    }
}
