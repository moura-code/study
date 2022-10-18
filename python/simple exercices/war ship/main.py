from estructura import *
from mlista import *
from abstraccion import *
#import abstraccion
# Barco: int int str int
crear("Barco", "X Y Orientacion Tamaño")
# Posiciones: int int int int
crear("Posiciones", "X1 Y1 X2 Y2")

def GuardarPosiciones(L):
    if L == listaVacia:
       return None
    elif cabeza(L).Orientacion == "H" or cabeza(L).Orientacion == 1:
        PH = Posiciones(cabeza(L).X,cabeza(L).Y,cabeza(L).X+1,cabeza(L).Y) # Posiciones(2,3,3,3)
        L1 = crearLista(PH,GuardarPosiciones(cola(L)))
        return L1
    elif cabeza(L).Orientacion == "V" or cabeza(L).Orientacion == 2:
        PV = Posiciones(cabeza(L).X,cabeza(L).Y,cabeza(L).X,cabeza(L).Y + 1) # Posiciones (1,1,1,2)
        L1 = crearLista(PV,GuardarPosiciones(cola(L)))
        return L1
#Prueba
#L = crearLista(Barco(6,3,"H",2),lista(Barco(8,2,"V",2),lista(Barco(1,3,"H",2),None)))
#print(GuardarPosiciones(L))
#print(L)
def ColocarBarco(bar,L):
 
    
  if L == listaVacia:
    return True
  elif bar.X < 1 or bar.X > 8 or bar.Y < 1 or bar.Y > 8:
    return False
  elif (bar.X != cabeza(L).X1 and bar.X != cabeza(L).X2) or (bar.Y != cabeza(L).Y1 and bar.Y != cabeza(L).Y2):
    return ColocarBarco(bar,cola(L))
  else:
    return False
#Prueba
def GuardarBarco(L,bar):
  s = GuardarPosiciones(L)
  R = ColocarBarco(bar,s)
  
  if R == False:
        return L
  else:
    L2 = GuardarPosiciones(crearLista(bar,None))
    L3 = crearLista(cabeza(L2),L)
    return L3


def PonerBomba(L,x,y):
    s = GuardarPosiciones(L)
    if L == listaVacia:
        return None
    elif (x != cabeza(s).X1 and x != cabeza(s).X2) or (y != cabeza(s).Y1 and y != cabeza(s).Y2):
        return PonerBomba(cola(L),x,y)
    else:
        return cabeza(L)
  
def EncontrarBarco(bar):
    if bar:
        return True
    else:
        return False

def EliminarBarco(L,bar):
  L3 = GuardarBarco(L,bar)
  print(L3)
  if L == listaVacia:
    return None
  elif L3 == L:
      return 
  else: 
    return None
L = crearLista(Barco(1,1,"H",2),lista(Barco(8,2,"V",2),lista(Barco(1,3,"H",2),None)))
bar = Barco(1,1,"H",2)
print(EliminarBarco(L,bar))
