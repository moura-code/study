
def ano_bisistio(ano:int) -> bool:
    if ano % 4 == 0 and ano % 400 ==0 and ano %100 == 0 :
        return True
    else:
        return False

def valida_fecha(ano:int,mes:int,dia:int)->bool:
    if ano >1000 and ano <10000:
        if mes >0 and mes <13:
            if dia >0 and dia <32:
                return True
    return False

ano = int(input('poner ano: '))
mes = int(input('poner mes: '))
dia = int(input('poner dia: '))

if valida_fecha(ano,mes,dia):
    print('la fecha es valida')
    if ano_bisie(ano):
        print('y ese ano es bisiesto')
