// See https://aka.ms/new-console-template for more information
Console.WriteLine("Binvenido a la CalculadoraV2");

string numeroString;
int resultadoEntero;
double numeroReal, resultadoReal;

Console.WriteLine("Ingrese un numero:");
numeroString = Console.ReadLine();
//int.TryParse(numero, out numeroInt);
double.TryParse(numeroString, out numeroReal);
resultadoReal = Math.Abs(numeroReal);
Console.WriteLine("El VALOR ABSOLUTO del numero ingresado es: " + resultadoReal);
resultadoReal = numeroReal * numeroReal;
Console.WriteLine("El CUADRADO del numero ingresado: " + resultadoReal);
if (numeroReal >= 0)
{
    resultadoReal = Math.Sqrt(numeroReal);
    Console.WriteLine("La RAIZ CUADRADA del numero ingresado es: " + resultadoReal);
}else
{
    Console.WriteLine("El numero ingresado es menor a 0, no es posible calcular su RAIZ CUADRADA.");
}
resultadoReal = Math.Sin(numeroReal);
Console.WriteLine("El SENO del numero ingresado es: " + resultadoReal);
resultadoReal = Math.Cos(numeroReal);
Console.WriteLine("El COSENO del numero ingresado es: " + resultadoReal);
resultadoEntero = (int)numeroReal;
Console.WriteLine("La PARTE ENTERA de el numero ingresado es: " + resultadoEntero);

double numero1, numero2;

Console.WriteLine("Ingrese un numero:");
do
{
    numeroString = Console.ReadLine();
    double.TryParse(numeroString, out numero1);

    if (!(double.TryParse(numeroString, out numero1)))
    {
        Console.WriteLine("Por favor, ingrese un numero valido");
    }  
} while (!(double.TryParse(numeroString, out numero1)));
Console.WriteLine("Ingrese otro numero:");
do
{
    numeroString = Console.ReadLine();
    double.TryParse(numeroString, out numero2);

    if (!(double.TryParse(numeroString, out numero2)))
    {
        Console.WriteLine("Por favor, ingrese un numero valido");
    }  
} while (!(double.TryParse(numeroString, out numero2)));

if (numero1 > numero2)
{
    Console.WriteLine("El maximo entre los numeros ingresados es: " + numero1 + " y el menor entre los numeros ingresados es " + numero2);
}else
{
    if (numero1 < numero2)
    {
        Console.WriteLine("El maximo entre los numeros ingresados es: " + numero2 + " y el minimo entre los numeros ingresados es: " + numero1);
    }else
    {
        Console.WriteLine("Los numeros ingresados son iguales.");
    }
}

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