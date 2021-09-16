# Demo Patrón Consumer-Producer

El objetivo de esta aplicación es demostrar el uso del patrón Consumer-Producer en C#.

El demo cuenta con una clase que se encarga de generar y consumir números aleatorios, y dos implementaciones de lógica que utilizan esa clase para generar y consumir datos. La primera implementación (_Naive_) no utiliza patrón de diseño, mientras que la segunda (_Pattern_) implementa el patrón [consumer-producer](http://tutorials.jenkov.com/java-concurrency/producer-consumer.html). Se puede alternar entre una implementación u otra cambiando la clase implementadora en el método Main.

Los principales elementos a destacar en el patrón son: la presencia de una cola/lista de elementos (normalmente concurrente) disponibles para ser consumidos, y procesos paralelos/asincrónicos para producir (ingresar elementos a la cola) y consumir (remover elementos de la cola).
