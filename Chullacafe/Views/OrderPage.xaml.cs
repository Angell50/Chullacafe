using System;
using System.Collections.ObjectModel;
using Chullacafe.Models;

namespace Chullacafe.Views
{
    public partial class OrderPage : ContentPage
    {
        public OrderPage()
        {
            InitializeComponent();

            // Enlazar el servicio con los datos de pedidos
            BindingContext = OrderService.Instance;
        }
    }

}
