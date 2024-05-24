// See https://aka.ms/new-console-template for more information
Console.WriteLine("Binvenido a la CalculadoraV2");

string opcion, numero;
int opcionInt, numeroInt;

do
{
    Console.WriteLine("Ingrese un numero para seleccionar una opcion\n1 para la operacion VALOR ABSOLUTO\n2 para la operacion CUADRADO\n3 para la operacion RAIZ CUADRADA\n4 para la operacion SENO\n5 para la operacion COSENO\n6 para la operacion PARTE ENTERA DE UN FLOAT");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionInt);
    switch (opcionInt)
    {
        case 1:
        Console.WriteLine("Ingrese un numero entero:");
        numero = Console.ReadLine();
        int salidaValorAbsoluto;
        int.TryParse(numero, out numeroInt);
        
        //uint salida;
        //uint.TryParse(numero, out salida);
        //Int32.TryParse(numero, out numeroInt);
        salidaValorAbsoluto = Math.Abs(numeroInt);
        Console.WriteLine("El valor absoluto del numero ingresado es: " + salidaValorAbsoluto);
            break;
        case 2:
        Console.WriteLine("Ingrese un numero entero:");
        numero = Console.ReadLine();
        int.TryParse(numero, out numeroInt);
        numeroInt = numeroInt * numeroInt;
        Console.WriteLine("El cuadrado del numero igresado es: " + numeroInt);
            break;
        case 3:
        Console.WriteLine("Ingrese un numero entero:");
        numero = Console.ReadLine();
        int.TryParse(numero, out numeroInt);
        if (numeroInt > 0)
        {
            double salidaRaiz;
            salidaRaiz = Math.Sqrt(numeroInt);
            Console.WriteLine("La raiz cuadrada del numero ingresado es: " + salidaRaiz);
        }else
        {
            Console.WriteLine("El numero ingresado es negativo:");
        }
            break;
        case 4:
        numero = Console.ReadLine();
        int.TryParse(numero, out numeroInt);
            break;
        case 5:
        numero = Console.ReadLine();
        int.TryParse(numero, out numeroInt);
            break;
        case 6:
        numero = Console.ReadLine();
        int.TryParse(numero, out numeroInt);
            break;
        default:
            break;
    }
} while (opcionInt != 0);