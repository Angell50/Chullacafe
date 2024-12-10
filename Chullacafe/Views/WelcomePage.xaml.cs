using Microsoft.Maui.Controls;

namespace Chullacafe.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        // Asegúrate de que el nombre del método coincida con el evento del botón
        private void OnStartButtonClicked(object sender, EventArgs e)
        {
            // Aquí va la lógica que deseas ejecutar cuando el botón es clickeado
            // Por ejemplo, puedes navegar a otra página:
            Navigation.PushAsync(new MenuPage()); // Si estás usando navegación
        }
    }
}
