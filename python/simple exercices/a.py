import os

def ordenar(personas) -> None:
    while True:
            ordenar = input('ordenar lista por nombre o por imc [N/I] (nombre o imc)').strip().upper()
            orden = input('acendente o decentende? [A/D]').strip().upper()
            if ordenar == 'N' and orden== 'A':
                personas = sorted (personas,key = lambda nombre: nombre[0])
                break
            if ordenar == 'N' and orden== 'D':
                personas = sorted (personas,key = lambda nombre: nombre[0] ,reverse=True)
                break
            if ordenar == 'I' and orden== 'A':
                personas = sorted(personas,key = lambda imc: imc[1])
                break
            if ordenar == 'I' and orden== 'D':
                personas = sorted(personas,key = lambda imc: imc[1],reverse=True)
                break
            print('###poner una opcion valida###')
    for i in personas:
        print(f'la persona {i[0]} su estado de salud es {i[2]} y su imc es {i[1]}')

def change(info,n):
    while True:
        os.system('CLS')
        for n2,j in enumerate(info[n]):
            print(f'[{n2}]{j}',end=' ')
        print(f'[{n2+1}] Eliminar [{n2+2}] Volver')
        n2+=2
        while True:
            try:
                inpu = int(input(f'porfavor selecionar un numero entre 0 y {n2} para cambiar o las otras opciones: '))
            
                if inpu > n2 or inpu < 0:
                    raise Exception()
                break
            except:
                print('porfavor poner un numero valido')
        if inpu == n2:
           del info[n]
           break
        elif inpu == n2-1:
            break
        else:
            cam = input('que queres poner aca')
            info[n][inpu] = cam
    return info

def consulta(info):
    os.system('CLS')
    print('todos las personas:')
    for n,i in enumerate(info):
        print(f'[{n}]{i[0]}',end=' ')
    print()
    while True:
        try:
            inpu = int(input(f'porfavor selecionar un numero entre 0 y {n}: '))

            if inpu > n or inpu < 0:
                raise Exception()
            break
        except:
            print('porfavor poner un numero valido')
    
    print('------------------')
    info = change(info,n)
    return info
def parame(lista)  -> None:
        menor = 0
        mayor = 0
        nameMayor = ''
        nameMenor = ''
        for i in lista:
            if i[1] >= mayor:
                mayor = i[1]
                nameMayor = i[0]
            if i[1] <= menor:
                menor= i[1]
                nameMenor = i[0]
        if nameMenor == nameMayor:
            print(f'La misma persona tiene el imc menor y mayor y es {nameMayor} y su imc es {mayor}')
        else:
            print(f'La persona con mayor imc es {nameMayor}  y su imc es {mayor}, El menor imc es de {nameMenor} y tiene de imc {menor}')
        

def main ():
    personas= []
    bajo_peso = 0
    peso_normal = 0
    sobrepeso = 0
    menores = 0
    posible = 0
    obesidad=0
    while True:
        l = ''
        datos = input('ingresar nombre edad estatura en centimetros y peso en libras: ').split()
        imc = (int(datos[3]) / 2.205) / (((int(datos[2]) /100)) ** 2)
        imc =  round(imc, 2) 
        if imc < 18.5:
            print('bajo peso')
            bajo_peso+=1
            l= 'bajo peso'
            if int(datos[1]) < 15:
                menores+=1
        if imc >= 18.5 and imc < 25:
            print('peso normal')
            peso_normal+=1
            l = 'peso normal'
        if imc >=25 and imc <30:
            print('sobrepeso')
            sobrepeso+=1
            l = 'sobrepeso'
        if imc >=25 and imc > 30:
            print('obesidad')
            obesidad+=1
            l = 'obesidad'
            if int(datos[1]) > 40:
                posible += 1
        personas.append((datos[0],imc,l))
        pregunta = input('agregar otro mas?').strip()
        if pregunta.upper() == 'S'or pregunta.upper() =='SI':
            pass
        else:
            break



    print(f'hay {bajo_peso} con bajo peso, hay {peso_normal} con peso normal, hay {sobrepeso} con sobrepeso y hay {obesidad} con obesidad')
    print(f' y los grupos que requieren atencion hay {menores} menores desnutridos y hay {posible} posibles infartos ')

    parame(personas)


    while True:

        try:
            print('deseas consultar las personas inseridas?')
            inpu = int(input(f'porfavor selecionar un numero entre [0]NO y [1]SI: '))
            if inpu > 1 or inpu < 0:
                raise Exception()

        except:
            print('porfavor poner un numero valido')
        if inpu == 0:
            break
        else:
            personas = consulta(personas)
    ordenar(personas)
main()

    

