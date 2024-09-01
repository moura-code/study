#include "../include/clientesSucursalesLDE.h"

struct rep_clientesSucursalesLDE {
	TClientesABB abb;
	int idSucursal;
	TClientesSucursalesLDE sig, ant;
};


TClientesSucursalesLDE crearTClientesSucursalesLDEVacia(){

	TClientesSucursalesLDE sur = new rep_clientesSucursalesLDE;

	sur->abb = NULL;
	sur->ant = NULL;

	sur->sig = NULL;

	return sur;
}

void insertarClientesABBTClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE, TClientesABB clientesABB, int idSucursal){

	if (clientesSucursalesLDE->abb == NULL)
	{

		clientesSucursalesLDE->abb = clientesABB;
		clientesSucursalesLDE->idSucursal = idSucursal;
		return;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;
	TClientesSucursalesLDE newsur = crearTClientesSucursalesLDEVacia();

	newsur->idSucursal=idSucursal;
	newsur->abb = clientesABB;

	while (p->ant != NULL && edadPromedioTClientesABB(p->ant->abb) > edadPromedioTClientesABB(clientesABB))
	{
		p= p->ant;
	}
	while (p->sig != NULL && edadPromedioTClientesABB(p->sig->abb) <= edadPromedioTClientesABB(clientesABB))
	{
		p = p->sig;
	}

	if (edadPromedioTClientesABB(p->abb) > edadPromedioTClientesABB(clientesABB))
	{
		newsur->sig = p;
		newsur->ant = p->ant;

		if (p->ant != NULL)
		{
			p->ant->sig = newsur;
		}
		p->ant = newsur;
	}
	else
	{

		newsur->ant = p;
		newsur->sig = p->sig;

		if (p->sig != NULL)
		{
			p->sig->ant = newsur; 
		}

		p->sig = newsur; 
	}
	while (p->ant != NULL)
	{
		p = p->ant;
	}
	clientesSucursalesLDE=p;
}

void liberarTClientesSucursalesLDE(TClientesSucursalesLDE &clientesSucursalesLDE){

	if (clientesSucursalesLDE->abb == NULL)
	{

		delete clientesSucursalesLDE;

		clientesSucursalesLDE = NULL;
		return;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->ant != NULL )
	{
		p = p->ant;
	}
	while (p != NULL )
	{
		if (p->abb != NULL)
		{
			liberarTClientesABB(p->abb);
		}
		TClientesSucursalesLDE b = p;
		p = p->sig;
		delete b;
		b = NULL;
	}
}

void imprimirTClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE){
	printf("clientesSucursalesLDE de grupos:\n");
	if (clientesSucursalesLDE == NULL ||clientesSucursalesLDE->abb == NULL)
	{
		return;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->ant != NULL)
	{
		p = p->ant;
	}
	while (p != NULL)
	{
		printf("Grupo con edad promedio %.2f:\n", edadPromedioTClientesABB(p->abb));
		imprimirTClientesABB(p->abb);
		p=p->sig;
	}
}

void imprimirInvertidoTClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE){
	printf("clientesSucursalesLDE de grupos:\n");
	if (clientesSucursalesLDE->abb == NULL)
	{
		return;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->sig != NULL)
	{
		p = p->sig;
	}
	
	while (p != NULL)
	{
		printf("Grupo con edad promedio %.2f:\n", edadPromedioTClientesABB(p->abb));
		imprimirTClientesABB(p->abb);
		p = p->ant;
	}
}

nat cantidadTClientesABBClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE){
	if (clientesSucursalesLDE == NULL )
	{
		return 0;
	}

	if (clientesSucursalesLDE->abb == NULL){
		return 0;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->ant != NULL)
	{
		p = p->ant;
	}
	nat total = 0;
	while (p != NULL)
	{
		++total;
		p = p->sig;
	}

	return total;
}

TClientesABB obtenerPrimeroClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE){
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->ant != NULL)
	{
		p = p->ant;
	}
	return p->abb;
}

TClientesABB obtenerNesimoClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE, int n){
	if ((int)cantidadTClientesABBClientesSucursalesLDE(clientesSucursalesLDE)< n){
		return NULL;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->ant != NULL)
	{
		p = p->ant;
	}
	int total = 1;

	while (total<n )
	{
		++total;
		p = p->sig;
	}
	return p->abb;
}

TClientesABB removerUltimoClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE){

	if (clientesSucursalesLDE == NULL || clientesSucursalesLDE->abb == NULL){
		return NULL;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;
	while (p->sig != NULL)
	{
		p = p->sig;
	}
	TClientesABB clientesABB = p->abb;

	if (p==clientesSucursalesLDE){
		clientesSucursalesLDE->abb = NULL;
		return clientesABB;
	}
	if(p->ant !=NULL){
		p->ant->sig = NULL;
	}
		

	p->abb= NULL;
	delete p;
	return clientesABB;
}

TClientesABB removerNesimoClientesSucursalesLDE(TClientesSucursalesLDE clientesSucursalesLDE, int n){
	if ((int)cantidadTClientesABBClientesSucursalesLDE(clientesSucursalesLDE) < n)
	{
		return NULL;
	}
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	while (p->ant != NULL)
	{
		p = p->ant;
	}
	int total = 1;

	while (total < n)
	{
		++total;
		p = p->sig;
	}
	TClientesABB client = p->abb;

	if (p == clientesSucursalesLDE)
	{
		clientesSucursalesLDE->abb = NULL;
		return client;
	}

	if (p->ant != NULL){
		p->ant->sig=p->sig;
	}
	if (p->sig != NULL)
	{
		p->sig->ant = p->ant;
	}
	p->abb = NULL;
	delete p;
	return client;
}

TCliente clienteMasRepetido(TClientesSucursalesLDE clientesSucursalesLDE){
	TClientesSucursalesLDE p = clientesSucursalesLDE;

	int veces[1000];

	for (int i = 0; i < 1000; i++)
	{
		veces[i] = 0;
	}
	while (p->ant != NULL)
	{
		p= p->ant;
	}
	int max = 0;
	while (p != NULL)
	{
		int n = cantidadClientesTClientesABB(p->abb);

		for (int i = 1; i <= n; i++)
		{
			TCliente cliente = obtenerNesimoClienteTClientesABB(p->abb, i);

			int id = idTCliente(cliente);
			++veces[id];

			if (id >= max){
				max = id;
			}
		}
		p = p->sig;
	}

	int biggest = 0;
	int biggestindex = 0; 
	for (int i = 0; i <= max; i++)
	{
		if (veces[i] > biggest){
			biggest = veces[i];
			biggestindex = i;
		}
	}
	TClientesSucursalesLDE j = clientesSucursalesLDE;
	while (j->ant != NULL)
	{
		j = j->ant;
	}
	while (j->sig != NULL)
	{
		if(existeTClienteTClientesABB(j->abb,biggestindex)){
			return obtenerTClienteTClientesABB(j->abb,biggestindex);
		};
		j = j->sig;
	}

	return NULL;

	

}
