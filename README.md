# Eventos-y-Movimiento-rectilineo

## 1 Crear un script para mover al objeto jugador con los ejes Horizontal y Vertical

![gif](./GIF/Move.gif)

## 2 Implementar una UI que permita configurar con qué velocidad te moverás: turbo o normal. También debe mostar la cantidad de objetos recolectados y si chocas con alguno especial restar fuerza.

### Velocidad Turbo o Normal con botones de la UI:

![gif](./GIF/Speed.gif)

### Recolectar monedas y actualizar la UI:

![gif](./GIF/Coin.gif)

### Recibir daño y reducir tu Vida / Fuerza en la UI:

![gif](./GIF/Danger.gif)

## 3 Agregar a tu escena un objeto que al ser recolectado por el jugador haga que otro objetos obstáculos se desplacen de su trayectoria.

![gif](./GIF/Recolect.gif)

## 4 Agrega un objeto que te teletransporte a otra zona de la escena.

![gif](./GIF/Teleport.gif)

## 5 Agrega un personaje que se dirija hacia un objetivo estático en la escena.

-> Restando la posición del objetivo con la posición del objeto a mover, podemos calcular el vector entre estos dos y moverlo en esa dirección.

![gif](./GIF/Objective.gif)

# 6  Agrega un personaje que siga el movimiento del jugador 

-> Añadimos la posibilidad del jugador de moverse por el escenario y establecemos otro objeto cuyo objetivo es el propio jugador al moverse. De esta forma podemos simular que el objeto nos sigue.

![gif](./GIF/Follow.gif)
