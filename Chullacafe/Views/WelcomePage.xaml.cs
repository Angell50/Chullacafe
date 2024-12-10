using Microsoft.Maui.Controls;

namespace Chullacafe.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        // Aseg�rate de que el nombre del m�todo coincida con el evento del bot�n
        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            // Aqu� va la l�gica que deseas ejecutar cuando el bot�n es clickeado
            // Por ejemplo, puedes navegar a otra p�gina:
            Navigation.PushAsync(new MenuPage()); // Si est�s usando navegaci�n
        }
    }
}
