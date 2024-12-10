using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chullacafe.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public List<Product> Products { get; set; }  // Lista de productos

        public Order()
        {
            Products = new List<Product>();
        }
    }
}

public class Product
{
    public string Name { get; set; }  // Nombre del producto
    public int Quantity { get; set; }  // Cantidad de ese producto en el pedido
    public decimal Price { get; set; }  // Precio del producto
}