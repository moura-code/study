from random import randint
cartela = [[randint(i-14,i) for i in [15,30,45,60,75]] for _ in range(5) ]
print('B  I  N  G  O')
for i in cartela:
    for j in i:
        if j<10:
            print(j,end='  ')
        else: print(j,end=' ')
    print()
