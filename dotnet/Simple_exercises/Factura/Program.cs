// See https://aka.ms/new-console-template for more information
using Factura;

internal class Program
{


    private static void Main(string[] args)
    {

        Console.WriteLine("Bien venido a la ferretería!");

        // Agrego a lista todos los productos
        List<Articulo> articulos = new List<Articulo>(){
            new Articulo(Valor: 12, Nome: "Martillo", Cantidad: 20),
            new Articulo(Valor: 53, Nome: "Pintura", Cantidad: 20), 
            new Articulo(Valor: 23, Nome: "Clavos", Cantidad: 20),
            new Articulo(Valor: 63, Nome: "Cerrucho", Cantidad: 20),
            new Articulo(Valor: 14, Nome: "Tornillo ", Cantidad: 20),
            new Articulo(Valor: 42, Nome: "Alicate", Cantidad: 20),
            new Articulo(Valor: 29, Nome: "Destornillador", Cantidad: 20),
            new Articulo(Valor: 72, Nome: "Sierra", Cantidad: 20),
            new Articulo(Valor: 58, Nome: "Tijera", Cantidad: 20),
            new Articulo(Valor: 67, Nome: "Pincel", Cantidad: 20),
        };
        
        Dictionary<Articulo, int> carrito = new Dictionary<Articulo, int>();

        
        while (true)
        {
        
        Console.WriteLine("Porfavor elegir el articulo que llevaras");
        for (int i = 0; i < articulos.Count; i++)
        {
            Console.Write($" [{i}]{articulos.ElementAt(i).nome} ");
        }
        

        var elegido = articulos.ElementAt(Convert.ToInt32(Console.ReadLine()));
        
        Console.WriteLine($"Cuantos del producto {elegido.nome} queres? hay {elegido.cantidad} en el stock actualmente y cuesta ${elegido.valor} : ");
        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(elegido.Elegido(num)){
                carrito.Add(elegido, num);
                break;
            }
            Console.WriteLine("Cantidad excede la cantidad en el stock porfavor eleji una cantidad menor");
        }
        
        Console.WriteLine("Agregar otro articulo al carrito o ver factura?: 1 o 2");

        if(Convert.ToInt32(Console.ReadLine())==2)
        {
            break;
        }
        }
        int total = 0;
        foreach (var item in carrito)
        {
            total += item.Key.Factura(item.Value);
        }
        Console.WriteLine($"total a pagar ${total}, Núm. Fact 1, Fecha {DateTime.Now.ToString()}");
        
    }
}