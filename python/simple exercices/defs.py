def primo(num:int) -> int and bool:
    for i in range(2,num//2+1):
        if num % i==0:
            return num,False
    return num , True  


di = {'pedro':1,'felipe':2,'juan':3}


o