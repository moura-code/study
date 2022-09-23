import os
from random import randint


def num_jugadores() -> int:
    # En esta funcion preguntare al usuario cuantos jugadores quiere que tenga el juego
    while True:
        try:
            num = int(input('Porfavor inserir el numero de jugadores que jugaram: '))
            # Si el input es valido pero no un valor esperado tira un error
            if num < 1:
                raise ValueError
            break
        except ValueError:
            print('Valor invalido')
    print(f'Numero de jugadores selecionado: {num} ')
    input(' -- Enter para proseguir -- ')
    os.system('cls')
    return num

def puntos(jugadores:list[dict]) -> None:
    os.system('cls')
    print('--------------------------------------------')
    for i  in jugadores:
        #verifico si el jugador es el ganador
        if i['casilla'] >= 25:
            print('ESTE ES EL GANADOR ' ,end=' | ')
        print(f'Jugador [{i["id"]}] esta en la casilla {i["casilla"]} teniendo {i["puntos"]} puntos')
    input('enter para proseguir')
        

def opcion() -> int:
    os.system('cls')
    while True:
        try:
            num = int(input('Porfavor inserir que deseas hacer \n[0]Jugar/Seguir jugando \n[1]Ver informacion de lo jugadores '))
            if num < 0 or num > 1:
                raise ValueError
            break
        except ValueError:
            print('Valor invalido')
    return num

def jugar(jugadores:list[dict]) -> list[dict] and bool :
    """
    Un dicionario con la informacion de cada obstaculo siendo la llave la casilla donde estara el obstaculo
    y la llave como una tupla de para donde ira el jugador y cuantos puntos ganara o perdera.
    """
    obstaculos = {5:(1,-4),10:(8,-2),14:(6,-8),8:(13,8),9:(9,5),15:(20,10),24:(24,6)}
    end = False
    
    # Hago un tiro de dado por jugador y despues vuelvo al menu
    for i in jugadores:
        print('-----------------')
        print(f'> turno del jugador {i["id"]} <')
        #Uso esta funcion para tener un numero random del 1 al 6
        dado = randint(1,6)
        print(f'Numero del dado tirado fue [{dado}]')

        # Los valores de casilla y puntos se actualizan de acuerdon con el numero del dado tirado
        i['casilla'] += dado
        i['puntos'] += dado
        print(f'Estas en la casilla {i["casilla"]}')
        
        # Me certifico que la casilla no esta adentro del dicionario de obstaculos y si es asi actualizo la casilla que esta el jugador
        # y la cantidad de puntos que tiene
        if i['casilla'] in obstaculos:
            print('##Caiste en un obstaculo!!##')
            #agarro la cantidad de puntos que gano
            punto = obstaculos[i["casilla"]][1]
            i['puntos'] += punto
            i['casilla'] = obstaculos[i['casilla']][0]
            
            print(f'ahora estas en la casilla {i["casilla"]} y ganaste {punto} puntos ademas ')
        if i['casilla'] >=25:
            end=True
            break
        input('Enter para proseguir')
    return jugadores, end

def main():
    # Empieza el promgrama #
    os.system('cls') # comando para limpiar la consola
    print('----------- Bienvenido al juego ------------')
    jugadores= []
    for i in range(1,num_jugadores()+1):
        jugadores.append({'id':i,'casilla':0,'puntos':0})
    while True:
        if opcion():
            puntos(jugadores)
        else:
            jugadores,end = jugar(jugadores)      
            if end:
                break
    print('El juego se termino, Gracias por jugar')
    print('=================== Enter para ver las informaciones finales =============================')
    puntos(jugadores)


main()