// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Bienvenido a la CalculadoraV1");

string opcion;
//opcion = Console.ReadLine();
int opcionNumerica = 0;


do
{
    Console.WriteLine("Seleccione un operacion de la calculadora:\n1 para la operacion SUMA\n2 para la operacion RESTA\n3 para la operacion MULTIPLICACION\n4 para la operacion DIVISION");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionNumerica);
    switch (opcionNumerica)
    {
        case 1:

            break;
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
    }
    Console.WriteLine("Desea realizar otra operacion? Ingrese 0 para NO, 1 para SI");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionNumerica);
} while (opcionNumerica != 0);
