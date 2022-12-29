


def imprimir(students):
    # Aca donde hare un enumerate en cada estudiante
    for num,i in enumerate(students):
        print(f'------Estudiante {num+1}------')
        print(f'Codigo del estudiante: {i["codigo"]}' )
        print(f'Genero del estudiante: {i["genero"]}' )
        print(f'Nombre del estudiante: {i["nombre"]}' )
        print(f'Edad del estudiante: {i["edad"]}' )
        print(f'Estado del estudiante: {i["estado"]}' )

    
def main():
    students = []
    #hago un sistema de validacion para cada input conun try catch para que no haya errores o que el input es valido
    while True:
        try:
            num = int(input('porfavor ingresar el numero de estudiantes que vas a ingresar: '))
            if num < 1:
                raise ValueError
            break
        except:
            print('input invalido')
    for _ in range(num):
        student = {}
        print('---------------------')
        while True:
           
            try:
                info = int(input('porfavor inserir codigo del estudiante: ').strip())
                if num < 1:
                    raise ValueError
                student['codigo'] = info
                break
            except:
                print('input invalido')
        while True:
            try:
                info = input('porfavor poner genero del estudiante [M/F]: ').upper().strip()
                if len(info) > 1  :
                    raise ValueError
                if info == 'M' or info =='F':
                    student['genero'] = info
                    break
                raise ValueError
            except:
                print('input invalido')
        while True:
            try:
                info = input('Porfavor inserir nombre del estudiante: ').strip()
                student['nombre'] = info
                break
            except:
                print('input invalido')
        while True:
            try:
                info = int(input('porfavor agregar edad del estudiante: '))
                if num < 1:
                    raise ValueError
                student['edad'] = info
                break
            except:
                print('input invalido')
        while True:
            try:
                info = int(input('Porfavor poner estado del estudiante [0] False [1] True: '))
                if info < 0 or info > 1:
                    raise ValueError
                if info:
                    student['estado'] = True
                else:
                    student['estado'] = False
                break
            except:
                print('input invalido')
        #Despues agrego el estudiante a la lista de estudiantes
        students.append(student)
    # Llamo la funcion imprimir pasando como parametro la lista de estudiantes
    imprimir(students)

main()