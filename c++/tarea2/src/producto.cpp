#include "../include/producto.h"

struct rep_producto {
    int id;
    TFecha entry;
    char name[MAX_NOMBRE_PRODUCTO];
    int price;
};


TProducto crearTProducto(int id, const char nombre[MAX_NOMBRE_PRODUCTO], int precio, TFecha fechaIngreso){

    TProducto product = new rep_producto;

    product->id = id;
    product->price = precio;
    product->entry = fechaIngreso;

    strcpy(product->name, nombre);

    
    return product;
}

int idTProducto(TProducto producto){
    return producto->id;
}

int precioTProducto(TProducto producto){
    return producto->price;
}

void imprimirTProducto(TProducto producto){

    printf("Producto: %d\n",producto->id);
    printf("%s\n", producto->name);
    printf("Precio: %d\n", producto->price);
    printf("Ingresado el: ");
    imprimirTFecha(producto->entry);

// <NombreProducto>
// Precio: <precio>
// Ingresado el: <Fecha>
    // <NombreProducto>
    // Precio: <precio>
    // Ingresado el: <Fecha>
}

void liberarTProducto(TProducto &producto){

    liberarTFecha(producto->entry);
    delete producto;
    producto = NULL;
}


