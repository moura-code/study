def solve2(a,b):
    
    primos = [ "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97"]
    count = 0
    
    
    c= 1176
    
    if b>=1000000:
        count +=2549
        c=1000000 
    elif b>=100000:
        count+=247
        c=100000 
    elif b>= 10000:
        count += 21
        c=10000

    if a >= 1000000:
        count -=2549
    elif a>=100000:
        count-=247
       
    elif a>= 10000:
        count -= 21
    a=c
    for i in range(a,b+1):
        
        if str(i**2)[:2] in primos  and str(i)[:2] in primos and (str(i**2).endswith(str(i)[-2:])):
            count+=1
            
    return count

import time
def solve(a,b):
    count=0
    primos = [ "11", "13", "17", "19", "23", "29", "31", "37", "41", "43", "47", "53", "59", "61", "67", "71", "73", "79", "83", "89", "97"]
     
    
    
    
    if a < 1176:
        a = 1176
    
    for i in range(a,b+1):
      if str(i**2)[:2] in primos  and str(i)[:2] in primos and (str(i**2).endswith(str(i)[-2:])):
            count+=1
           
    
    return count
print(solve(2,1000000))

def last_survivors(st):
    st = list(st)
    
    text = 'abcdefghijklmnopqrstuvwxyza'
    res = {i:st.count(i) for i in st}
    while True:
        res = {j:res[j]+1 for (j,k) in res if text.index()}
        res = {j:k-2 for (j,k) in res }
        return ''.join(res)