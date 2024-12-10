using System;
using Chullacafe.Models; // Asegúrate de que esta referencia apunte a la clase Order
using Microsoft.Maui.Controls;

namespace Chullacafe.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void OnViewOrderSummaryClicked(object sender, EventArgs e)
        {
            // Leer cantidades de las entradas
            int americanoQty = string.IsNullOrWhiteSpace(AmericanoEntry.Text) ? 0 : int.Parse(AmericanoEntry.Text);
            int mocaccinoQty = string.IsNullOrWhiteSpace(MocaccinoEntry.Text) ? 0 : int.Parse(MocaccinoEntry.Text);
            int capuccinoQty = string.IsNullOrWhiteSpace(CapuccinoEntry.Text) ? 0 : int.Parse(CapuccinoEntry.Text);

            // Crear pedidos basados en las cantidades
            if (americanoQty > 0)
            {
                OrderService.Instance.AddOrder(new Order
                {
                    OrderNumber = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    Total = americanoQty * 2.5m // Precio de ejemplo: $2.5 por Americano
                });
            }

            if (mocaccinoQty > 0)
            {
                OrderService.Instance.AddOrder(new Order
                {
                    OrderNumber = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    Total = mocaccinoQty * 3.5m // Precio de ejemplo: $3.5 por Mocaccino
                });
            }

            if (capuccinoQty > 0)
            {
                OrderService.Instance.AddOrder(new Order
                {
                    OrderNumber = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    Total = capuccinoQty * 4.0m // Precio de ejemplo: $4.0 por Capuccino
                });
            }

            // Navegar a la página de resumen de pedidos
            Shell.Current.GoToAsync("OrderPage");
        }
    }
}
