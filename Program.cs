// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Bienvenido a la CalculadoraV1");

string opcion;
opcion = Console.ReadLine();
int opcionNumerica = 0;
int.TryParse(opcion, out opcionNumerica);

do
{
    Console.WriteLine("Seleccione un operacion de la calculadora:\n1 para la operacion SUMA\n2 para la operacion RESTA\n3 para la operacion MULTIPLICACION\n4 para la operacion DIVISION");
    switch (opcionNumerica)
    {
        
        default:
            break;
    }
} while (opcionNumerica < 0 || opcionNumerica > 4);
