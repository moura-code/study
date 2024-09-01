
from math import sqrt



n = 30031
prime_flag = 0
for i in range(2, int(sqrt(n)) + 1):
        if (n % i == 0):
            print(i)
            prime_flag = 1
            break
if (prime_flag == 0):
        print("True")
else:
        print("False")