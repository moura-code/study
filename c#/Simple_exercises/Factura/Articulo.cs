

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

    public bool Elegido (int Cuantidad){
        if(Cuantidad > this.cantidad)
        {
            this.cantidad = this.cantidad = Cuantidad;
            return true;
        }
        return false;
    }
    public int Factura(int num){
        int total = num*this.valor;
        Console.WriteLine($"Compraste {num} de {this.nome} y sobram {this.cantidad} entoces el precio final de este producto sera {num}x ${valor}:{total}");
        return total;
    }
    }
    
}