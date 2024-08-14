
count = 0
for i in range (1,9999999+1):
    s = str(i)
    if sum([int(x) for x in s ]) == 31:
        count +=1
print(count)
        