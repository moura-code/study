def separate(st):
    l = []
    
    num1 = 0
    num2 = 1
    num3 = 0

    for _ in range(len(st)):
        start = ''
        while True:
            try:
                if st[num1] != st[num2]:
                    start += st[num3:num2]
                    
                    num1+=1
                    num2+=1
                    break
                
            except IndexError:
                l.append(st[num3:num2])
                return l

             
            num1+=1
            num2+=1
        num3=num1
        if start:
            l.append(start)
    return l
def phone_words(st):
    #416666663105558822255
    if not (st):
        return ''
    
    d = {'0':' ','00':'  ','000':'   ','1':'','11':'','111':'','2':'a','22':'b','222':'c','3':'d','33':'e','333':'f','4':'g','44':'h','444':'i','5':'j','55':'k','555':'l','6':'m','66':'n','666':'o','7':'p','77':'q','777':'r','7777':'s','8':'t','88':'u','888':'v','9':'w','99':'x','999':'y','9999':'z'}
    l = separate(st)
    final = []
    for i in range(len(l)):
        try:
            
            final.append(d[l[i]])
            
        except:
            
            
            palabra = l[i]
            count = 3

            if palabra[0] in ['9','7']:
                count = 4
            num = count
            final.append(d[palabra[:count]])
            
            while True:
                try:
                    final.append(d[palabra[count:count+num]])
                except:
                    break
                count+=num
            print(final)
                
            
          
            
    return ''.join(final)



print(phone_words('77777777333333190'))