# 2023-II Examen de Recuperacion

## Instrucciones Generales del Examen:
El examen consta de desarrollar un videojuego implementando las funcionalidades solicitadas.

No se puede usar Assets o codigos previamente desarrollados. No se puede implementar funcionalidades o configuraciones realizadas por terceros.

El examen se debe desarrollar en la branch principal "master". Se debe tener al menos 2 Commits con avances del examen.

Recordatorio: El examen es presencial y personal. Se deberá compartir la pantalla donde se está desarrollando el examen.


## Instrucciones Especificas del Examen (Habilitadas a las 8:30 am UTC -5)

Se debe desarrollar un videojuego de resolver un rompecabezas de 9 piezas. El minijuego es sencillo, pero debe estar los más pulido y presentable posible.

* **Reglas del Videojuego:**
    1) Las piezas deben empezar de manera desordenada, tanto en posición como en rotación.
    2) El jugador puede utilizar las telcas WASD o las Flechas Direccionales para irse moviendo entre las piezas.
    3) El jugador puede utilizar la tecla Q para girar en 90° a la izquierda, y E para girar 90° a la derecha.
    4) El jugador puede utilizar la Barra Espaciadora para seleccionar una Pieza y cambiarla de posición.
    5) El jugador puede utilizar la Barra Espaciadora para confirmar el cambio de piezas.
    6) El jugador puede utilizar la tecla ESC para cancelar el cambio y desseleccionar la pieza.
    7) Cuando el rompecabezas haya terminado, se debe mostrar la imagen completa.
    
* **Requerimientos del Videojuego:**
    1) Las piezas deben empezar de manera desordenada en el tablero, y su orden de solución es fijo. (2 Puntos)
    2) Solo se puede controlar 1 Pieza a la vez, ya sea para rotar o intercambiar. (4 Puntos)
    3) Las pizas solo pueden rotar individualmente en un ángulo de 90°, y se tiene que esperar a que gire completamente antes de volver a girar. (3 Puntos)
    4) Tiene que haber una animación de rotación, y de que se está seleccionando dicho bloque (ver video demostrativo). (3 Puntos)
    5) Se debe utilizar el New Input System de Unity. (2 Punto)
    6) Se debe utilizar Scriptable Objects para la gestión de las piezas. (2 Puntos)
    7) Se debe utilizar eventos para las interacciones de las piezas (feedback) y validar acciones. (4 Puntos)