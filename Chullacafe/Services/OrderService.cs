using Chullacafe.Models;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

public class OrderService
{
    private const string FileName = "orders.txt";
    private readonly string FilePath;

    public ObservableCollection<Order> Orders { get; private set; } = new ObservableCollection<Order>();

    // Singleton: Asegura que haya solo una instancia de OrderService en la aplicación.
    private static OrderService _instance;
    public static OrderService Instance => _instance ??= new OrderService();

    private OrderService()
    {
        FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), FileName);
        LoadOrdersFromFile();
    }

    // Cargar pedidos desde el archivo de texto
    public void LoadOrdersFromFile()
    {
        if (File.Exists(FilePath))
        {
            try
            {
                string fileContent = File.ReadAllText(FilePath);
                var orders = JsonSerializer.Deserialize<ObservableCollection<Order>>(fileContent);
                if (orders != null)
                {
                    Orders = orders;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo de pedidos: {ex.Message}");
            }
        }
    }

    // Guardar pedidos en el archivo de texto
    public void SaveOrdersToFile()
    {
        try
        {
            string fileContent = JsonSerializer.Serialize(Orders);
            File.WriteAllText(FilePath, fileContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al guardar el archivo de pedidos: {ex.Message}");
        }
    }

    // Agregar un nuevo pedido
    public void AddOrder(Order order)
    {
        Orders.Add(order);
        SaveOrdersToFile();
    }
}
