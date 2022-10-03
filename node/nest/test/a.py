def primo(num):
    for i in range(2,num//2+1):
        if num%i==0:
            return False
    return True  
def capicua():     
    for i in range(10000000001,1000000000000000000+1):
        num_s=str(i)
        num_list=list(num_s)
        if num_list==num_list[::-1]:
            if primo(i):
                print(i,True)
            else: print(i,False)
capicua()