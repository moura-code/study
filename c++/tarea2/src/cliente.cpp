#include "../include/cliente.h"

struct rep_cliente
{
    int id, age;
    char name[MAX_NOMBRE];
    char surname[MAX_APELLIDO];
};

TCliente crearTCliente(int id, const char nombre[MAX_NOMBRE], const char apellido[MAX_APELLIDO], int edad)
{
    TCliente client = new rep_cliente;

    client->id = id;
    client->age = edad;
    strcpy(client->name, nombre);

    strcpy(client->surname, apellido);

    return client;
}

void imprimirTCliente(TCliente cliente)
{

    printf("Cliente %s %s\n", cliente->name, cliente->surname);
    printf("Id: %d\n", cliente->id);
    printf("Edad: %d\n", cliente->age);

    //
    // Id: <idCliente>
    // Edad: <edad>
}

void liberarTCliente(TCliente &cliente)
{

    delete cliente;
    cliente = NULL;
}

void nombreTCliente(TCliente cliente, char nombre[MAX_NOMBRE])
{

    strcpy(nombre, cliente->name);
}

void apellidoTCliente(TCliente cliente, char apellido[MAX_APELLIDO])
{
    strcpy(apellido, cliente->surname );
}

int idTCliente(TCliente cliente)
{
    return cliente->id;
}

int edadTCliente(TCliente cliente)
{
    return cliente->age;
}

TCliente copiarTCliente(TCliente cliente)
{

    TCliente client = new rep_cliente;

    client->id = cliente->id;
    client->age = cliente->age;
    strcpy(client->name, cliente->name);

    strcpy(client->surname, cliente->surname);

    return client;
}
