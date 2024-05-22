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
    string numero;
    int numero1 = 0, numero2 = 0, resultado = 0;
    switch (opcionNumerica)
    {
        case 1:
            Console.WriteLine("Ingrese el primer numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero1);
            Console.WriteLine("Ingrese el segundo numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero2);
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado es: " + resultado);
            break;
        case 2:
            Console.WriteLine("Ingrese el primer numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero1);
            Console.WriteLine("Ingrese el segundo numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero2);
            if (numero1 < numero2)
            {
                Console.WriteLine("El primer numero es menor que el segundo, no es posible realizar la operacion RESTA");
            }else
            {
                resultado = numero1 - numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }
            break;
        case 3:
            Console.WriteLine("Ingrese el primer numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero1);
            Console.WriteLine("Ingrese el segundo numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero2);            
            break;
        case 4:
            Console.WriteLine("Ingrese el primer numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero1);
            Console.WriteLine("Ingrese el segundo numero:");
            numero = Console.ReadLine();
            int.TryParse(numero, out numero2);
            if (numero1 < numero2)
            {
                Console.WriteLine("El primer numero es menor que el segundo numero, no es posible realizar la operacion DIVICION.");
            }else
            {
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado es: " + resultado);
            }
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? Ingrese 0 para NO, 1 para SI");
    opcion = Console.ReadLine();
    int.TryParse(opcion, out opcionNumerica);
} while (opcionNumerica != 0);
