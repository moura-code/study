import os
def primo(num):
    for i in range(2,num//2+1):
        if num%i==0:
     
            return False
    return True  
def capicua(i):
        num_s=str(i)
        num_list=list(num_s)
        if num_list==num_list[::-1]:
            print(i)
            if primo(i):
                print(i,True)
            else: 
                
                os.system('cls')
for i in range(100):
    capicua(int(f'1{"0"*i}3{"0"*i}1'))