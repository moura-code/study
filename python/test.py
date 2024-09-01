def sieve_of_eratosthenes(n):
    # Create a boolean array "prime[0:n+1]" and initialize all entries as True.
    prime = [True] * (n + 1)
    p = 11
    while p * p <= n:
        # If prime[p] is not changed, then it is a prime
        if prime[p]:
            # Updating all multiples of p to False
            for i in range(p * p, n + 1, p):
                prime[i] = False
        p += 1
    
    # Collecting all prime numbers
    primes = [p for p in range(2, n + 1) if prime[p]]
    return primes
def is_prime(number):
    # Special cases
    if number <= 1:
        return False
    if number <= 3:
        return True
    if number % 2 == 0 or number % 3 == 0:
        return False
    
    # Check divisibility from 5 to the square root of the number
    i = 5
    while i * i <= number:
        if number % i == 0 or number % (i + 2) == 0:
            return False
        i += 6
    
    return True
# Example usage:
n = 1000000
prime_numbers = sieve_of_eratosthenes(n)
for i in range(1,len(prime_numbers)//4):
    total = 1
    
    for j in prime_numbers[:i]:
        total = total*j
    total+=1
    if not is_prime(total):
        print(prime_numbers[:i])
        print(total)
    
