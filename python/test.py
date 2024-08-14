
a = []


for i in range (1,1000):
    if len([j for j in str(i) if (int(j) % 2) == 0 ]) ==len(str(i)):
        a.append(i)
        
element = 200
print(a.index(element)+1)