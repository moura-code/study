namespace Factura
{
     public class Articulo
    {
    public int cantidad {get; set;}
    public int valor {get; set;}
    public string nome {get; set;}
    public Articulo(int Valor, string Nome, int Cantidad)
    {
            valor = Valor;
            nome = Nome;
            cantidad = Cantidad;
    }

    //Verifica si la cantidad elegida por el usuario es valida
    public bool Elegido (int Cuantidad){
        
        if(Cuantidad < this.cantidad)
        {
            
            this.cantidad = this.cantidad - Cuantidad;
            return true;
        }
        return false;
    }
    //Genera la factura y muestra en el terminal y lo hace return para sumar al total
    public int Factura(int num){
        int total = num*this.valor;
        Console.WriteLine($"Compraste {num} de {this.nome} y sobram {this.cantidad} entoces el precio final de este producto sera {num}x${valor} :{total}");
        Console.WriteLine();
        return total;
    }
    }
}