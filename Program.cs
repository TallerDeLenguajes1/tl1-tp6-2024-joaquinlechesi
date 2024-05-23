// See https://aka.ms/new-console-template for more information
Console.WriteLine("Binvenido a la CalculadoraV2");

string opcion;
int opcionInt;

do
{
    Console.WriteLine("Ingrese un numero para seleccionar una opcion\n1 para la operacion VALOR ABSOLUTO\n2 para la operacion CUADRADO\n3 para la operacion RAIZ CUADRADA\n4 para la operacion SENO\n5 para la operacion COSENO\n6 para la operacion PARTE ENTERA DE UN FLOAT");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionInt);
    switch (opcionInt)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
        default:
            break;
    }
} while (opcionInt != 0);