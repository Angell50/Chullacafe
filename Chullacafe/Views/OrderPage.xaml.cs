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

            BindingContext = OrderService.Instance;
        }
    }

}
