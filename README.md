# Tenedor
TrabajoPractico3

Tenedor
<<Atributos>>
vida:entero
velocidad:entero
position:Vector2
daño:entero
sala:entero
<<Comandos>>
Muerte()
Ataque(vidajugador)
RecibirDaño(dañojugador)
SeguirJugador(salajugador)
<<Consultas>>
ObtenerVida(vida)
ObtenerSala(sala)


Este código corresponde a una adaptación de una clase de un proyecto más grande desarrollado en Godot. En el proyecto original, se trata
de un enemigo (“Tenedor”) dentro de un roguelike rítmico con una temática humorística.
Para este trabajo práctico, la clase fue simplificada para poder ejecutarse en C# base sin depender del motor. Por esa razón, algunas
decisiones de implementación difieren de la versión original. Por ejemplo, se utiliza un INT para representar la posición en lugar de
estructuras como Vector2 que son propias de motores como Godot. Este tipo de simplificaciones permite centrarse en la lógica del
comportamiento (vida, daño, seguimiento del jugador, etc.) sin necesidad de incorporar librerías externas.
Los comentarios en el código reflejan justamente estas adaptaciones, indicando dónde se reemplazaron elementos del motor por versiones
más simples. De esta manera, se conserva la idea general del sistema original, pero en un formato más accesible y testeable.
