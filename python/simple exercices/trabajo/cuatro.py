
class Alumno():

    nombre:str ; apellido:str ; sexo : 'F' or 'M'
    edad : int

    def __init__(self, nombre:str , apellido: str , sexo: str, edad: int) -> None:
        self.nombre = nombre
        self.apellido = apellido
        self.sexo = sexo
        self.edad = edad
    def getEdad(self) -> int:
        return self.edad
    def mostrarDatos(self) -> None:
        print(f'{self.nombre} {self.apellido} tiene {self.edad} y es {self.sexo}') 

alumnos = [ ['juan','rodriguez','Masculino',21] , ['pablo','duarte','Masculino',23] ,['ana','victoria','Femenino',19], ['bernardo','bugatti','Masculino',22], ['martina','ruiz','Femenino', 19] ]
print('La informacion de los alumnos son:')
countM = 0
countF = 0
hombres = 0
mujeres = 0
for i in alumnos:
    
    alumno = Alumno(nombre=i[0], apellido=i[1], sexo=i[2],edad = i[3])
    alumno.mostrarDatos()

    if i[2] == 'Masculino': 
        print('pene')
        hombres += alumno.getEdad() 
        countM +=1
    else:  
        mujeres += alumno.getEdad() 
        countF +=1

print(f'Y el promedio de edad de los honbres es {hombres/countM} y de las mujeres es {mujeres/countF}')
