#include "../include/carritoProductos.h"

struct rep_carritoProductos{
    TProducto producto;
    TCarritoProductos sig;
};


TCarritoProductos crearCarritoProductosVacio(){

    TCarritoProductos carrito = new rep_carritoProductos;
    carrito->sig = NULL;
    carrito->producto = NULL;

    return carrito;
}

void insertarProductoCarritoProductos(TCarritoProductos &carritoProductos, TProducto producto){
    
    if (carritoProductos->producto == NULL)
    {

        carritoProductos->producto = producto;
        return;
    }
    TCarritoProductos nuevo = crearCarritoProductosVacio();
    nuevo->producto = producto;
    if (idTProducto(carritoProductos->producto) > idTProducto(producto))
    {
        nuevo->sig = carritoProductos;

        carritoProductos = nuevo;
        return;
    }
    TCarritoProductos p = carritoProductos;

    while (p->sig != NULL && idTProducto(p->sig->producto) < idTProducto(producto))
    {
        p = p->sig;
    }
    TCarritoProductos temp = p->sig;
    p->sig = nuevo;
    nuevo->sig = temp;

    
}

void imprimirCarritoProductos(TCarritoProductos carritoProductos){
    if (carritoProductos == NULL){
        return;
    }
    TCarritoProductos p = carritoProductos;

    while (p != NULL && p->producto != NULL){
        imprimirTProducto(p->producto);
        p=p->sig;
    }
}

void liberarCarritoProductos(TCarritoProductos &carritoProductos){
    if (carritoProductos == NULL )
    {
        
        return;
    }
    
    TCarritoProductos p = carritoProductos;
    while (p != NULL )
    {

        if (p->producto != NULL)
        {
            liberarTProducto(p->producto);
        }
        TCarritoProductos b = p;
        p = p->sig;
        delete b;
        b=NULL;
    }
    carritoProductos=NULL;
}

bool esVacioCarritoProductos(TCarritoProductos carritoProductos){

    return carritoProductos == NULL || carritoProductos->producto == NULL ;
}

bool existeProductoCarritoProductos(TCarritoProductos carritoProductos, int idProducto){
    TCarritoProductos p = carritoProductos;

    while (p != NULL)
    {
        if ((p->producto) &&( idTProducto(p->producto) == idProducto)){ return true; }
        p = p->sig;
    }
    return false;
}

TProducto obtenerProductoCarritoProductos(TCarritoProductos carritoProductos, int idProducto){
    TCarritoProductos p = carritoProductos;
    while (p != NULL)
    {
        if (idTProducto(p->producto) == idProducto)
        {
            return p->producto;
        }
        p = p->sig;
    }
    return NULL;
}

void removerProductoCarritoProductos(TCarritoProductos &carritoProductos, int idProducto){

    if (!existeProductoCarritoProductos(carritoProductos, idProducto))
    {
        return;
    }
    TCarritoProductos p = carritoProductos;
    if (idTProducto(carritoProductos->producto) == idProducto){
        liberarTProducto(carritoProductos->producto);
        if (carritoProductos->sig != NULL){
            TCarritoProductos temp = carritoProductos;
            carritoProductos = carritoProductos->sig;
            delete temp;
            temp = NULL;
        }
        return;
    }
    while (idTProducto(p->sig->producto) != idProducto)
    {
        p = p->sig;
    }

    TCarritoProductos temp = p;
    temp = p->sig;
    p ->sig = temp->sig;

    liberarTProducto(temp->producto);
    delete temp;
    temp = NULL;
}