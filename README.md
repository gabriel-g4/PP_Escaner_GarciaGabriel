<style> img {
    margin: 0 auto;
    display: block;
}
</style>


<img alt="imagen de portada utn-fra" src="./images/portada%20utn-fra.png" style="margin: 25px auto;">


<h1 style="text-align:center"> <p> PP - LABORATORIO II </p> 1er CUATRIMESTRE 2024</h1>

## Requerimientos 

En una biblioteca se van a escanear dos tipos de documento: mapas y libros. Necesitamos un programa que nos permita saber en qué paso del proceso tenemos cada uno de los documentos que se van a escanear y también sacar indicadores de tipo cuantitativo.

Los pasos del proceso, es decir, los estados en los que podemos encontrar los documentos (de cualquiera de los dos tipos) son los siguientes:

* __Inicio__: el valor por defecto de los documentos.

* __Distribuido__: el documento ya está en el escáner que le corresponde.

* __EnEscaner__: el documento está siendo escaneado.

* __EnRevision__: el documento está en el paso del proceso en el que se revisa si el escaneo no tuvo fallos (problemas de pixelado, páginas faltantes…).

* __Terminado__: el documento ya ha sido escaneado y aprobado pues el proceso de revisión fue positivo.

\
El programa tendrá mecanismos de control para no cometer el error de escanear dos veces el mismo documento.

En el caso de libros, se considerará que son el mismo libro cuando:

* Tenga el mismo barcode o

* Tenga el mismo ISBN o

* Tenga el mismo título y el mismo autor.

En el caso de los mapas, se considerará que son el mismo mapa cuando:

* Tenga el mismo barcode o

* Tenga el mismo título y el mismo autor y el mismo año y la misma superficie.

\
El escáner de los mapas (cama plana de gran formato) está en la mapoteca y es distinto al de los libros (escáner con alimentador de páginas) el cual está en la oficina de procesos técnicos.

Se precisa un módulo de informes que nos permita saber, teniendo en cuenta tipo de documento y estado, los siguientes datos:

* Extensión de lo que hay en cada uno de los estados (número de páginas en el caso de libros, superficie en caso de mapas).

* Cantidad de ítems en cada uno de los estados.

* Datos de cada uno.

## Esquema

La solución debe llamarse “PP_Escaner_ApellidoNombre” por ejemplo: _PP_Escaner_RusMataSilvia_ y estar en NET 7.0.

Y debe contener dos proyectos:

* "Entidades" (Biblioteca de clases)

* "Test" (Consola)

## Biblioteca de clases

### <ins>__Documento y derivados__<ins>

![clase documento](./images/clase%20documento.png)

* La propiedad de NumNormalizado solo debe poder verse desde las clases derivadas.

* El estado debe inicializarse como "Inicio".

* El método ToString() debe usar StringBuilder para mostrar todos los datos del documento.

* El método AvanzarEstado() debe pasar al siguiente estado dentro del orden que se estableció en el requerimiento. Debe devolver false si el documento ya está terminado.

![clase libro](./images/clase%20libro.png)

![clase mapa](./images/clase%20mapa.png)

* La sobrecarga del operador == debe funcionar según lo descripto en el requerimiento para cada uno de los dos tipos de documento.

* La propiedad ISBN en los libros muestra el NumNormalizado.
Los mapas no tienen NumNormalizado.

* La superficie de los mapas se calcula multiplicando alto por ancho.

* El método ToString() debe mostrar todos los datos del documento en cuestión (los de la clase de la que heredan y los propios, incluida la superficie en el caso de los mapas). Usar StringBuilder.

* La información sobre los libros debe mostrarse así:

![output libro](./images/output%20libro.png)

* La información sobre los mapas debe mostrarse así:

![output mapa](./images/output%20mapa.png)

---
### <ins>__Escáner__<ins>

![clase escaner](./images/clase%20escaner.png)

* El constructor debe inicializar la lista de documentos.

* El constructor inicializa la locación según el tipo de documento a escanear (si es
“mapa” la locación es “mapoteca” y si es “libro” va a “procesosTecnicos”).

* La sobrecarga del operador “==” comprueba si hay un documento igual en la lista.
Devuelve true si encuentra, false si no.

* La sobrecarga del operador “+” añade el documento a la lista de documentos en el
caso de que no haya un documento igual ya en ella. También debe añadirlo solo si
está en estado “Inicio”. Antes de añadirlo a la lista debe cambiar el estado a
“Distribuido”.

* El método “CambiarEstadoDocumento()” cámbiará el estado del documento de
dentro de la lista de documentos.


---
### <ins>__Informes__<ins>

![clase informes](./images/clase%20informes.png)

* Cada uno de los informes públicos devolverá, dado un escáner y un estado en el que deban encontrarse los documentos tenidos en cuenta, los siguientes datos:

    * Extensión: el total de la extensión de lo procesado según el escáner y el estado. Es decir, el total de páginas en el caso de los libros y el total de cm² en el caso de los mapas.

    * Cantidad: el número total de ítems únicos procesados según el escáner y el estado.

    * Resumen: se muestran los datos de cada uno de los ítems contenidos en una lista según el escáner y el estado.

## Consola

Usar para hacer el testeo necesario de las funcionalidades requeridas. Será usada para hacer la corrección.

## Criterios de corrección

El examen debe ser entregado mediante Github informado vía form. El día del examen la
cátedra proporcionará un código para testear la aplicación mediante el proyecto de consola
y la salida esperada.

Motivos de desaprobación directa (nota = 2):

* La solución no compila.

* La solución muestra warnings que no son del tipo:

    * _'class' defines operator == or operator != but does not override
    Object.Equals(object o)_

    * _'class' defines operator == or operator != but does not override
    Object.GetHashCode()_
    
* El programa lanza excepciones no controladas cuando se ejecuta el código de
testing proporcionado por la cátedra.

* El último commit es posterior a 22/05/2024 a las 13:59.

Requisitos para llegar al 4:

* La salida por terminal después de ejecutar el código de testing proporcionado es
similar en un 80% a la salida esperada.

* El código no registra errores graves tales como repetición de varias líneas de código.

Requisitos para llegar al 6:

* La salida por terminal después de ejecutar el código de testing proporcionado es
exactamente igual a la esperada.

Requisitos para llegar al 8:

* La salida por terminal después de ejecutar el código de testing proporcionado es
exactamente igual a la esperada.

* El código sigue lo estudiado en la materia referido a los pilares de la POO.

OPCIONAL: +2 puntos:

* Solo podrán sumarse si se tiene un 6 de partida.

* El programa incluye una excepción CONTROLADA creada ad-hoc para el código
propuesto en la presente consigna. Se deberá defender oralmente.

* El parcial con la excepción debe ser una solución distinta al parcial sin la excepción
que se corregirá en primer lugar.

* Se debe defender oralmente en todos los casos.

En todos los casos en los que la nota sea 4 o mayor, se puede llamar al alumno a defensa
oral siendo obligatoria para todos los que hayan añadido una excepción controlada. Para la
defensa se debe contar con una cámara y un micrófono además de presentar el DNI propio
al momento de la defensa. De no cumplir con estas condiciones la nota será 2.