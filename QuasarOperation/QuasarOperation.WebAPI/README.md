# Meli.QuasarOperation

Challenge Mercado Libre

## General

La web api consta de 2 controllers

 * TopSecretController       
 * TopSecretSplitController

Mi idea fue utilizar SOLID para desacoplar lo m�ximo posible cada componente

La webapi est� documentada con **swagger** donde tambi�n se podr�n ejecutar cada operaci�n disponible.
La webapi cuenta con un contenedor docker 

Consta de un proyecto de _QuasarOperationDataAccess_ donde implemento los repositorios, eleg� hacerlo en memoria por la poca cantidad de datos que 
necesitaba persistir, pero permitir al estar desacoplado poder implementar un acceso a base de datos f�sica.

La l�gica de negocio esta implementada en el proyecto de _QuasarOperation.Services_ los cuales se injectan en los controllers de la webapi

El pryecto _QuasarOperation.Domain_ se encuentran modeladas las entidades de dominio y las interfaces tanto de los repositorios como de los services



## TopSecretController       
 Recibe una colecci�n de transmisiones mediante un POST
 Este controller espera siempre que se especifiquen las transmisiones a los 3 satellites para devolver una respuesta
 caso contrario devuelve 404  o 400 si el request est� incompleto
 

## TopSecretSplitController
 Este controller esta dise�ado para recibir una transmisi�n por vez mediante POST
 en caso de que ya exista una para el mismo sat�lite esta se actualiza
 
 Mediante GET puede intentar recuperar el mensaje y la ubicaci�n de la nave en caso de ser posible, caso contrario se obteiene un SatusCode 404 
 
 
## Como utilizar la webapi

La misma cuenta con swagger  pero tambi�n la pueden acceder directamente

 ### para utilizarla con swagger
    https://meli-challenge-alan.rj.r.appspot.com/swagger/index.html  

 ### para accederla directamente
    https://meli-challenge-alan.rj.r.appspot.com/api/TopSecret
    https://meli-challenge-alan.rj.r.appspot.com/api/TopSecretSplit
  
  Pueden utilizar aplicaciones como POSTMAN para hacer las pruebas (recomiendo usar swagger ya que esta disponible en la misma webapi)
  