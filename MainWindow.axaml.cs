using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MeuProjetoAvalonia;

public partial class MainWindow : Window
{

    string medida;

    public MainWindow()
    {
        InitializeComponent();
    }

    // Evento chamado quando o botão é clicado
    private void BtnClique_Click(object sender, RoutedEventArgs e)
    {
        // Recupera o valor digitado no TextBox pelo nome definido no XAML (txtInput)
        var valor = this.FindControl<TextBox>("txtInput").Text;
        

        // Exibe uma mensagem alterando o texto do próprio TextBox como exemplo
        if (!string.IsNullOrEmpty(valor))
        {
            this.FindControl<TextBlock>("resultado").Text = valor;
        }
        else
        {
            // Caso o usuário não tenha digitado nada, exibe uma mensagem padrão
            this.FindControl<TextBlock>("resultado").Text = valor;
        }
    }

    private void tiposDeMedidas_SelectionChanged(object sender, RoutedEventArgs e)
    {
        var comboBox = sender as ComboBox;

        if (comboBox.SelectedItem is ComboBoxItem item)
        {
            medida = (string)item.Content;
        }else{
            medida = "";
        }
    }
	
}