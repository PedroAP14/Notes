using System.Diagnostics;

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
            if (conteudo != null)
            {
                File.WriteAllText(caminho, conteudo);
                DisplayAlert("Arquivo Salvado Com Sucesso", "", "Ok");
            }
            else
            {
                DisplayAlert("ALERTA", "Não foi encontrado um conteúdo para ser salvo", "Ok");
            }
                

        }

        private void AoClicarlNoApagar(object? sender, EventArgs e)
        {
            File.Delete(caminho);
            EditorAnotacao.Text = null;
            DisplayAlert("Arquivo Apagado Com Sucesso", "", "Ok");
        }

        private void AoClicarlNoCarregar(object? sender, EventArgs e)
        {
            try
            {
                EditorAnotacao.Text = File.ReadAllText(caminho);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                DisplayAlert("ALERTA", "Arquivo Não Encontrado!!!", "Ok");
            }
               
        }
    }
}
