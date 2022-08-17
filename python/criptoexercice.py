def rotacion(palabra,abajo):
    ln = len(str(palabra))
    rotacion = abajo[:-ln]
    rotacion = [letra for letra in rotacion]
    
    h=[]
    for i in abajo:
        if i not in rotacion:
            h.append(i)
    for i in reversed(h):
        rotacion.insert(0,i)
    abajo = rotacion
    return rotacion , abajo

    
def cripto2(palabra,arriba,baja):
   
    
    final=''
    for i in palabra:
        i = i.lower()
        if i in arriba:
            j = arriba.index(i)
            z = baja[j]
            final += z
        if i in baja:
            j = baja.index(i)
            z = arriba[j]
            final += z
        
    return final

def main(frase):
    arriba ='abcdefghijklmn'
    arriba = [letra for letra in arriba]
    abajo = 'ñopqrstuvwxyz-'
    palabras = frase.split()
    text = ""
    
    for palabra in palabras:
        rotaci, _ = rotacion(palabra,abajo)
        text += str(cripto2(palabra,arriba,rotaci))
        _ , abajo =  rotacion(palabra,abajo)
        text += " "
    return text
print(main('La casa solitaria de la montaña'))