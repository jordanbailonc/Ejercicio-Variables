document.write ("fase 1"+  "<br>");
var nombre = "Jordan";
var apellido1 ="Bailon";
var apellido2 = "Cercado";
document.write (nombre + " "+ apellido1 + " "+ apellido2+"<br>");
var dia= 18;
var mes =6;
var año= 1997;
document.write (dia + " /"+ mes+ " /"+ año + "<br>");

document.write ("fase 2" + "<br>");
const bisiesto = 1948;
const intervaloAños =4;
var nacimiento = 1997;
var resultado = ((nacimiento- bisiesto)/intervaloAños);
resultado = parseInt(resultado);
document.write("Hay " + resultado + " años bisiestos entre " + bisiesto +" y "+ nacimiento + "<br>");


/*ATENCIO! Haureu de canviar el tipus de variable de l’any 1948 per poder modificar-la.  
Creeu una variable bool que sera certa si l’any de naixement és de traspàs o falsa si no ho és. 
En cas de que la variable bool sigui certa, heu de mostrar per consola una frase on ho digui, en cas de ser falsa mostrareu la frase pertinent.
Creeu dues variables string per guardar les frases.  
Creeu una variable on juntareu el nom i els cognoms (tot en una variable) i un altre on juntareu la data de naixement separada per “/” (tot en una variable). 
Mostreu per consola les variables del nom complet, la data de naixement i si l’any de naixement es de traspàs o no.*/

document.write ("fase 3" + "<br>")
var fullName = "Jordan Fernando Bailon Cercado";
var fechaNacimiento =  "18/06/1997";

 //La variable añoInicio se usa en dentro del bucle que está comentado en la línea "46".

var añoInicio = bisiesto;
var fraseVerdad = "es una año bisiesto";
var fraseFalso = "no es un año bisisesto";
document.write ("Mi nombre es "+ fullName + "<br>");
document.write ("Nací el " + fechaNacimiento+ "<br>");
if (nacimiento % 4 == 0)
        {
            document.write("Mi año de nacimiento" + fraseVerdad + "<br>");
        }else if (nacimiento % 4 != 0)
        {
            document.write("Mi año de nacimiento" + fraseFalso+ "<br>");
        }
//Partint de l’any 1948 heu de fer un bucle for i mostrar els anys de traspàs fins arriba al vostre any de naixement. 

    /*for ( i = añoInicio; i <= añoNacimiento; i++){
    if (i % 4 == 0){
            document.write(i + fraseVerdad);
            }else if (i % 4 != 0){
            document.write (i + fraseFalso);
            }
        }*/