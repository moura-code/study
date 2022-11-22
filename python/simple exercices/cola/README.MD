### Explicare todo el codigo aca
Mostrare y explicare toda la parte de la clase PriorityQueue

```python
def insert_or_update(self, priority, data):
        self.data_dict[data] = priority
```
En esta funcion agrego al dicionario data_dict con llave la data y el valor la priority

```python
def extract(self):
        try:
            lowest = min(self.data_dict.items(), key=lambda x: x[0]) 
            self.data_dict.pop(lowest[0],None)
        except ValueError:
            return None
        while lowest[1] in self.data_dict.values():
            self.data_dict.pop(list(self.data_dict.keys())[list(self.data_dict.values()).index(lowest[1])]) 
            
        return (lowest)
```
La funcion extract empieza usando un try para buscar el menor elemento del dicionarion y si no pasa ningun error lo sacara del dicionario y despues buscara en el dicionario otros con la misma prioridad y los sacara, si algun error ocurre en el try retornara none

```python
def peek(self):
        try:
            lowest = min(self.data_dict.items(), key=lambda x: x[0]) 
        except ValueError:
            return None
        return (lowest)
```
Lo mismo que el extract pero este no sacara del dicionario, solo lo retornara si hay un valor en el, si no retornara none

```python
def __str__(self):
        return self.data_dict

    # Return number of elements in the queue
    def __len__(self):
        return len(self.data_dict)

    # Return True if queue is empty, False otherwise
    def is_empty(self):
        # Return queue is empty
        return ( self.peek() != None )
```
El __str__ retornara simplesmente el dicionario
El __len__ retornara el len del dicionario
Y la def is_empty usara la funcion peek para ver si esta vacio el dicionario, si esta vacio retornara truel, si no false

#### Para finalizar si te fijas en el archivo Test_PQ.py y corres todos los tests, vas a ver como todos estan correctos y con un tiempo esperablemente razonable
