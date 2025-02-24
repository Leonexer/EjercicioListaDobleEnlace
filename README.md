# Instrucciones
Se proporciona el código base de una lista enlazada de ejemplo. Estúdialo y utilízalo como referencia.
Implementa una lista doblemente enlazada que incluya las siguientes características:
- Un campo que indique si la lista es circular o no.
- Métodos para inserción, eliminación y recorrido (impresión) de elementos.
- Métodos que consideren si la lista es circular para evitar recorridos infinitos.

Asegúrate de que la estructura y las operaciones sean funcionales y eficientes.

# Procedimiento
Para este procedimiento utilizamos un nodo que almacene un dato, apunte a un nodo anterior y a un nodo siguiente.
- Creamos la clase List que como parametro requiere un Bool, si este es true la lista será circular, de lo contrario solo será doblemente enlazada.
- Creamos dos nodos, un Head y un Tail, como primer y ultimo elemento de la lista respectivamente.
- Creamos una función CheckCircular, la revisa el Bool utilizado como parámetro y si este es true: El nodo anterior a Head apuntará a la Tail y el nodo siguiente a Tail apuntará a Head (Podemos llamar a esta función al final de cadda procedimiento para no tener que escribir dos códigos enteros)
- Creamos las funciones Prepend para añadir al tope y Append para añadir al final, al igual que un DeleteFirst y un DeleteLast respectivamente.
- Por ultimo creamos una función Print, mediante un ciclo que empieza desde la Head y recorre la lista hacia enfrente imprimiendo cada elemento, y una función PrintBackwards que funciona igual que Print, excepto que esta empieza desde Tail y en ves de recorrerse hacia adelante se recorre hacia atras.
