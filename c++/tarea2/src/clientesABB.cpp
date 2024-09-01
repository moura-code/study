#include "../include/clientesABB.h"

struct rep_clientesABB
{
    TCliente client;

    TClientesABB izq, der;
};

TClientesABB crearTClientesABBVacio()
{
    TClientesABB abb = new rep_clientesABB;

    abb->client = NULL;
    abb->der = NULL;
    abb->izq = NULL;
    return abb;
}

void insertarTClienteTClientesABB(TClientesABB &clientesABB, TCliente cliente)
{

    if (clientesABB == NULL)
    {
        clientesABB = crearTClientesABBVacio();
        clientesABB->client = cliente;
        return;
    }

    if (clientesABB->client == NULL)
    {
        clientesABB->client = cliente;
        return;
    }
    if (idTCliente(cliente) < idTCliente(clientesABB->client))
    {
        insertarTClienteTClientesABB(clientesABB->izq, cliente);
    }
    else
    {
        insertarTClienteTClientesABB(clientesABB->der, cliente);
    }
}

void imprimirTClientesABB(TClientesABB clientesABB)
{

    if (clientesABB == NULL || clientesABB->client == NULL)
    {
        return;
    }


    imprimirTClientesABB(clientesABB->izq);
    imprimirTCliente(clientesABB->client);
    imprimirTClientesABB(clientesABB->der);
}

void liberarTClientesABB(TClientesABB &clientesABB)
{
    if (clientesABB==NULL){
        return;
    }
    if (clientesABB->client != NULL)
    {
        liberarTCliente(clientesABB->client);
    }

    liberarTClientesABB(clientesABB->der);
    liberarTClientesABB(clientesABB->izq);

    delete clientesABB;
    clientesABB = NULL;
}

bool existeTClienteTClientesABB(TClientesABB clientesABB, int idCliente)
{

    if (clientesABB == NULL || clientesABB->client == NULL)
    {
        return false;
    }

    if (idTCliente(clientesABB->client) == idCliente)
    {
        return true;
    }
    else if (idCliente < idTCliente(clientesABB->client))
    {
        return existeTClienteTClientesABB(clientesABB->izq, idCliente);
    }
    else
    {
        return existeTClienteTClientesABB(clientesABB->der, idCliente);
    }
}

TCliente obtenerTClienteTClientesABB(TClientesABB clientesABB, int idCliente)
{
  
    if (idTCliente(clientesABB->client) == idCliente)
    {
        return clientesABB->client;
    }
    else if (idCliente < idTCliente(clientesABB->client))
    {
        return obtenerTClienteTClientesABB(clientesABB->izq, idCliente);
    }
    else
    {
        return obtenerTClienteTClientesABB(clientesABB->der, idCliente);
    }
}

nat alturaTClientesABB(TClientesABB clientesABB)
{

    
    if ( clientesABB->client == NULL)
        {
            return 0;
        }
    if (clientesABB->der == NULL && clientesABB->izq == NULL)
    {
        return 1;
    }
    nat nder = (clientesABB->der == NULL) ? 0 : alturaTClientesABB(clientesABB->der);
    nat nizq = (clientesABB->izq == NULL) ? 0 : alturaTClientesABB(clientesABB->izq);

    return (nder > nizq) ? nder+1 : nizq+1;
}

TCliente maxIdTClienteTClientesABB(TClientesABB clientesABB)
{
    if (clientesABB->der == NULL )
    {
        
        return clientesABB->client;
    }

    return maxIdTClienteTClientesABB(clientesABB->der);
}

void removerTClienteTClientesABB(TClientesABB &clientesABB, int idCliente)
{
    if (clientesABB==NULL){
        return;
    }
    if (idCliente == idTCliente(clientesABB->client)){

        if (clientesABB->der == NULL && clientesABB->izq == NULL){
            liberarTClientesABB(clientesABB);
            return;
        }
        if (clientesABB->der == NULL)
        {
            TClientesABB p = clientesABB;

            clientesABB = clientesABB->izq;
                

            liberarTCliente(p->client);

            delete p;
            p = NULL;
            return;
        }
        if (clientesABB->izq == NULL)
        {
            TClientesABB p = clientesABB;

            clientesABB = clientesABB->der;

            liberarTCliente(p->client);
            
            delete p;
            p = NULL;
            return;
        }

        TCliente cli = maxIdTClienteTClientesABB(clientesABB);

        TCliente cli2 = copiarTCliente(cli);
        removerTClienteTClientesABB(clientesABB,idTCliente(cli));

        liberarTCliente(clientesABB->client);
        clientesABB->client = cli2;
        return;
    }

    if (idCliente < idTCliente(clientesABB->client))
    {
        return removerTClienteTClientesABB(clientesABB->izq, idCliente);
    }
    else
    {
        return removerTClienteTClientesABB(clientesABB->der, idCliente);
    }
}

int cantidadClientesTClientesABB(TClientesABB clientesABB)
{
    if (clientesABB == NULL || clientesABB->client == NULL)
    {
        return 0;
    }
    return cantidadClientesTClientesABB(clientesABB->der) + cantidadClientesTClientesABB(clientesABB->izq)+1;
}
int edadClientesTClientesABB(TClientesABB clientesABB)
{
    if (clientesABB == NULL || clientesABB->client == NULL)
    {
        return 0;
    }
    return edadClientesTClientesABB(clientesABB->der) + edadClientesTClientesABB(clientesABB->izq) + edadTCliente(clientesABB->client);
}

float edadPromedioTClientesABB(TClientesABB clientesABB){
    float totalcli = (float) cantidadClientesTClientesABB(clientesABB);

    return totalcli ? ((float) edadClientesTClientesABB(clientesABB) / totalcli) : 0;
}

TCliente obtenerNesimoClienteTClientesABB(TClientesABB clientesABB, int n)
{
    int num_izq = cantidadClientesTClientesABB(clientesABB->izq) + 1; 
    if (n < num_izq)
    {
        return obtenerNesimoClienteTClientesABB(clientesABB->izq, n);
    }
    else if (n == num_izq)
    {
        return clientesABB->client;
    }
    else
    {
        return obtenerNesimoClienteTClientesABB(clientesABB->der, n - num_izq);
    }
}
