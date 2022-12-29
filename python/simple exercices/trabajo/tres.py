
class Fraccion(object):

    numerador: int
    denomidador: int 
    def __init__(self,numerador: int, denomidador: int ) -> None:
        self.denomidador = denomidador
        self.numerador = numerador

    def mostrar (self) -> None:
        print(f'{self.numerador}/{self.denomidador}')
        

    def sumar (self, fraccion: int or float ) -> int or float:
        return fraccion + ( self.numerador/self.denomidador )

fracion1 = Fraccion( numerador =  1, denomidador = 3 )
fracion2 = Fraccion( numerador =  1, denomidador = 5 )

print(f'Las fraciones son:')
fracion1.mostrar(); fracion2.mostrar()

print(f'Y la suma de estas fraciones es: {fracion1.sumar(fracion2.numerador/fracion2.denomidador)}')
