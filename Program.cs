﻿// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

Console.WriteLine("Bienvenido al Ejercicio 4\nPor favor ingrese un cadena de texto:");

string cadena;

cadena = Console.ReadLine();

int longitudCadena;

longitudCadena = cadena.Length;

Console.WriteLine("La longitud de la consola ingresada es: " + longitudCadena);

Console.WriteLine("Ingrese una segunda cadena de texto");

string cadena2;

cadena2 = Console.ReadLine();

string cadena3 = cadena + cadena2;

Console.WriteLine("La cadena final resultado de concatenar las dos cadenas es: " + cadena3);
string numero;
int num1 = 0, num2 = 0, resultado = 0;
Console.WriteLine("Ingrese el primer numero:");
do
{
    numero = Console.ReadLine();
    int.TryParse(numero, out num1);
    if (!(int.TryParse(numero, out num1)))
    {
        Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
    }
} while (!(int.TryParse(numero, out num1)));
Console.WriteLine("Ingrese el segundo numero:");
do
{
    numero = Console.ReadLine();
    int.TryParse(numero, out num2);
    if (!(int.TryParse(numero, out num2)))
    {
        Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
    }
} while (!(int.TryParse(numero, out num2)));
resultado = num1 + num2;
Console.WriteLine("El resultado de sumar " + num1.ToString() + " y de " + num2.ToString() + " es igual a: " + resultado.ToString());

Console.WriteLine("Ingrese una cadena de texto:");
cadena = Console.ReadLine();
foreach (var item in cadena)
{
    Console.WriteLine(item);
}

bool ocurrencia;
string cadenaDeOcurrencia;
Console.WriteLine("Ingrese una cadena de texto:");
cadena = Console.ReadLine();
Console.WriteLine("Ingrese la cadena a buscar dentro de la cadena de texto previamente ingresada:");
cadenaDeOcurrencia = Console.ReadLine();

if (ocurrencia = cadena.Contains(cadenaDeOcurrencia))
{
    Console.WriteLine("La cadena ingresada SI se encuentra dentro de la otra cadena.");
}else
{
    Console.WriteLine("La cadena ingresada NO se encuentra dentro de la otra cadena.");
}

Console.WriteLine("Ingrese la cadena a convertir en una cadena en MAYUSCULAS.");
cadena = Console.ReadLine();
Console.WriteLine("La cadena en MAYUSUCULAS ES:\n" + cadena.ToUpper() + "\nLa cadena en minusculas es:\n" + cadena.ToLower());

Console.WriteLine("Ingrese una cadena de texto nuevamente:");
cadena = Console.ReadLine();
string separador = " ";
string[] matrizCadena; //definir una matriz
matrizCadena = cadena.Split(separador);
Console.WriteLine("Los resultados de separar la cadena son:");
foreach (var item in matrizCadena)
{
    Console.WriteLine(item);
}

Console.WriteLine("Ingrese el calculo que desea realizar, por ejemplo: 528+2 (recuerde usar el simbolo / para la division y el simbolo * para lamultiplicacion)");
cadena = Console.ReadLine();
string operacion = "0";
do
{    
    if (cadena.Contains("+"))
    {
        matrizCadena = cadena.Split("+");
        operacion = "+";
    }else
    {
        if (cadena.Contains("-"))
        {
            matrizCadena = cadena.Split("-");
            operacion = "-";
        }else
        {
            if (cadena.Contains("*"))
            {
                matrizCadena = cadena.Split("*");
                operacion = "*";
            }else
            {
                if (cadena.Contains("/"))
                {
                    matrizCadena = cadena.Split("/");
                    operacion = "/";
                }else
                {
                    Console.WriteLine("No se pudo indentificar la operacion, intente nuevamente.");
                }
            }
        }
    }
    if (cadena.Contains("+") || cadena.Contains("-") || cadena.Contains("*"))
    {
        int.TryParse(matrizCadena[0], out num1);
        int.TryParse(matrizCadena[1], out num2);
        switch (operacion)
        {
            case "+":
            resultado = num1 + num2;
                break;
            case "-":
            resultado = num1 - num2;
                break;
            case "*":
            resultado = num1 * num2;
                break;
        }
        Console.WriteLine("El resultado de la operacion seleccionada es: " + resultado);
    }else
    {
        if (cadena.Contains("/"))
        {
            int.TryParse(matrizCadena[0], out num1);
            int.TryParse(matrizCadena[1], out num2);      
            double resultadoFloat;
            resultadoFloat = (double)num1 / num2;
            Console.WriteLine("El resultado de la operacion seleccionada es: " + resultadoFloat);
        }
    }
} while (!(cadena.Contains("+") || cadena.Contains("-") || cadena.Contains("*") || cadena.Contains("/")));

// // See https://aka.ms/new-console-template for more information
// using System.Security;

// Console.WriteLine("Bienvenido a la CalculadoraV1");

// string opcion;
// //opcion = Console.ReadLine();
// int opcionNumerica = 0;


// do
// {
//     Console.WriteLine("Seleccione un operacion de la calculadora:\n1 para la operacion SUMA\n2 para la operacion RESTA\n3 para la operacion MULTIPLICACION\n4 para la operacion DIVISION");
//     opcion = Console.ReadLine();
//     int.TryParse(opcion, out opcionNumerica);
//     switch (opcionNumerica)
//     {
//         case 1:
//             break;
//         case 2:
//             Console.WriteLine("Ingrese el primer numero:");
//             do
//             {
//                 numero = Console.ReadLine();
//                 int.TryParse(numero, out numero1);
//                 if (!(int.TryParse(numero, out numero1)))
//                 {
//                     Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
//                 }
//             } while (!(int.TryParse(numero, out numero1)));
//             Console.WriteLine("Ingrese el segundo numero:");
//             do
//             {
//                 numero = Console.ReadLine();
//                 int.TryParse(numero, out numero2);
//                 if (!(int.TryParse(numero, out numero2)))
//                 {
//                     Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
//                 }
//             } while (!(int.TryParse(numero, out numero2)));
//             if (numero1 < numero2)
//             {
//                 Console.WriteLine("El primer numero es menor que el segundo, no es posible realizar la operacion RESTA");
//             }else
//             {
//                 resultado = numero1 - numero2;
//                 Console.WriteLine("El resultado es: " + resultado);
//             }
//             break;
//         case 3:
//             Console.WriteLine("Ingrese el primer numero:");
//             do
//             {
//                 numero = Console.ReadLine();
//                 int.TryParse(numero, out numero1);
//                 if (!(int.TryParse(numero, out numero1)))
//                 {
//                     Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
//                 }
//             } while (!(int.TryParse(numero, out numero1)));
//             Console.WriteLine("Ingrese el segundo numero:");
//             do
//             {
//                 numero = Console.ReadLine();
//                 int.TryParse(numero, out numero2);
//                 if (!(int.TryParse(numero, out numero2)))
//                 {
//                     Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
//                 }
//             } while (!(int.TryParse(numero, out numero2)));
//             resultado = numero1 * numero2;
//             Console.WriteLine("El resultado es: " + resultado);
//             break;
//         case 4:
//             Console.WriteLine("Ingrese el primer numero:");
//             do
//             {
//                 numero = Console.ReadLine();
//                 int.TryParse(numero, out numero1);
//                 if (!(int.TryParse(numero, out numero1)))
//                 {
//                     Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
//                 }
//             } while (!(int.TryParse(numero, out numero1)));
//             Console.WriteLine("Ingrese el segundo numero:");
//             do
//             {
//                 numero = Console.ReadLine();
//                 int.TryParse(numero, out numero2);
//                 if (!(int.TryParse(numero, out numero2)))
//                 {
//                     Console.WriteLine("No se ingreso un numero, por favor intente nuevamente.");
//                 }
//             } while (!(int.TryParse(numero, out numero2)));
//             if (numero1 < numero2)
//             {
//                 Console.WriteLine("El primer numero es menor que el segundo numero, no es posible realizar la operacion DIVICION.");
//             }else
//             {
//                 double resultadoDivicion;
//                 resultadoDivicion = (double)numero1 / numero2;
//                 Console.WriteLine("El resultado es: " + resultadoDivicion);
//             }
//             break;
//         default:
//             Console.WriteLine("El numero ingresado no perntence a una operacion.");
//             break;
//     }
//     Console.WriteLine("Desea realizar otra operacion? Ingrese 0 para NO, 1 para SI");
//     do
//     {
//         opcion = Console.ReadLine();
//         int.TryParse(opcion, out opcionNumerica);
//         if (!(int.TryParse(opcion, out opcionNumerica)))
//         {
//             Console.WriteLine("Ingreso un numero/caracter distinto a 0 o 1, por favor intente nuevamente\nDesea realizar otra operacion? Ingrese 0 para NO, 1 para SI");
//         }
//     } while (!(int.TryParse(opcion, out opcionNumerica)));
// } while (opcionNumerica != 0);

// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Binvenido a la CalculadoraV2");

// string numeroString;
// int resultadoEntero;
// double numeroReal, resultadoReal;

// Console.WriteLine("Ingrese un numero:");
// numeroString = Console.ReadLine();
// //int.TryParse(numero, out numeroInt);
// double.TryParse(numeroString, out numeroReal);
// resultadoReal = Math.Abs(numeroReal);
// Console.WriteLine("El VALOR ABSOLUTO del numero ingresado es: " + resultadoReal);
// resultadoReal = numeroReal * numeroReal;
// Console.WriteLine("El CUADRADO del numero ingresado: " + resultadoReal);
// if (numeroReal >= 0)
// {
//     resultadoReal = Math.Sqrt(numeroReal);
//     Console.WriteLine("La RAIZ CUADRADA del numero ingresado es: " + resultadoReal);
// }else
// {
//     Console.WriteLine("El numero ingresado es menor a 0, no es posible calcular su RAIZ CUADRADA.");
// }
// resultadoReal = Math.Sin(numeroReal);
// Console.WriteLine("El SENO del numero ingresado es: " + resultadoReal);
// resultadoReal = Math.Cos(numeroReal);
// Console.WriteLine("El COSENO del numero ingresado es: " + resultadoReal);
// resultadoEntero = (int)numeroReal;
// Console.WriteLine("La PARTE ENTERA de el numero ingresado es: " + resultadoEntero);

// double primerNumero, segundoNumero;

// Console.WriteLine("Ingrese un numero:");
// do
// {
//     numeroString = Console.ReadLine();
//     double.TryParse(numeroString, out primerNumero);

//     if (!(double.TryParse(numeroString, out primerNumero)))
//     {
//         Console.WriteLine("Por favor, ingrese un numero valido");
//     }  
// } while (!(double.TryParse(numeroString, out primerNumero)));
// Console.WriteLine("Ingrese otro numero:");
// do
// {
//     numeroString = Console.ReadLine();
//     double.TryParse(numeroString, out segundoNumero);

//     if (!(double.TryParse(numeroString, out segundoNumero)))
//     {
//         Console.WriteLine("Por favor, ingrese un numero valido");
//     }  
// } while (!(double.TryParse(numeroString, out segundoNumero)));

// if (primerNumero > segundoNumero)
// {
//     Console.WriteLine("El maximo entre los numeros ingresados es: " + primerNumero + " y el menor entre los numeros ingresados es " + segundoNumero);
// }else
// {
//     if (primerNumero < segundoNumero)
//     {
//         Console.WriteLine("El maximo entre los numeros ingresados es: " + segundoNumero + " y el minimo entre los numeros ingresados es: " + primerNumero);
//     }else
//     {
//         Console.WriteLine("Los numeros ingresados son iguales.");
//     }
// }

// do
// {
//     Console.WriteLine("Ingrese un numero para seleccionar una opcion\n1 para la operacion VALOR ABSOLUTO\n2 para la operacion CUADRADO\n3 para la operacion RAIZ CUADRADA\n4 para la operacion SENO\n5 para la operacion COSENO\n6 para la operacion PARTE ENTERA DE UN FLOAT");
//     opcion = Console.ReadLine();
//     int.TryParse(opcion, out opcionInt);
//     switch (opcionInt)
//     {
//         case 1:
//         Console.WriteLine("Ingrese un numero entero:");
//         numero = Console.ReadLine();
//         int salidaValorAbsoluto;
//         int.TryParse(numero, out numeroInt);
        
//         //uint salida;
//         //uint.TryParse(numero, out salida);
//         //Int32.TryParse(numero, out numeroInt);
//         salidaValorAbsoluto = Math.Abs(numeroInt);
//         Console.WriteLine("El valor absoluto del numero ingresado es: " + salidaValorAbsoluto);
//             break;
//         case 2:
//         Console.WriteLine("Ingrese un numero entero:");
//         numero = Console.ReadLine();
//         int.TryParse(numero, out numeroInt);
//         numeroInt = numeroInt * numeroInt;
//         Console.WriteLine("El cuadrado del numero igresado es: " + numeroInt);
//             break;
//         case 3:
//         Console.WriteLine("Ingrese un numero entero:");
//         numero = Console.ReadLine();
//         int.TryParse(numero, out numeroInt);
//         if (numeroInt > 0)
//         {
//             double salidaRaiz;
//             salidaRaiz = Math.Sqrt(numeroInt);
//             Console.WriteLine("La raiz cuadrada del numero ingresado es: " + salidaRaiz);
//         }else
//         {
//             Console.WriteLine("El numero ingresado es negativo:");
//         }
//             break;
//         case 4:
//         Console.WriteLine("Ingrese un numero entero:");
//         numero = Console.ReadLine();
//         int.TryParse(numero, out numeroInt);
//         double salidaSeno;
//         salidaSeno = Math.Sin(numeroInt);
//         Console.WriteLine("El SENO del numero ingresado es: " + salidaSeno);
//             break;
//         case 5:
//         Console.WriteLine("Ingrese un numero entero:");
//         numero = Console.ReadLine();
//         int.TryParse(numero, out numeroInt);
//         double salidaCoseno;
//         salidaCoseno = Math.Cos(numeroInt);
//         Console.WriteLine("El COSENO del numero ingresado es: " + salidaCoseno);
//             break;
//         case 6:
//         Console.WriteLine("Ingrese un numero real:"); //funciona ingresando numero reales con ","
//         numero = Console.ReadLine();
//         double numeroDouble;
//         //int.TryParse(numero, out numeroInt);
//         double.TryParse(numero, out numeroDouble);
//         numeroInt = (int)numeroDouble;
//         Console.WriteLine("La parte entera del numero real ingresado es: " + numeroInt);
//             break;
//         default:
//             break;
//     }
// } while (opcionInt != 0);