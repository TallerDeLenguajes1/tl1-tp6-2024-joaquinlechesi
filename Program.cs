// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Ingresa un numero para invertir !");
string numeroAi;
numeroAi = Console.ReadLine();
int numero = 0;
int.TryParse(numeroAi, out numero);
int aux = 0;
int invertido = 0;
int resto = 0;
if (numero > 0)
{
    if (numero > 10)
    {
        aux = numero;
        do
        {
            resto = aux % 10;
            aux = aux / 10;
            invertido = invertido + resto;
            invertido = invertido * 10;
        } while (aux >= 10);
        invertido = invertido + aux;
        Console.WriteLine("El numero invertido es: " + invertido);
    }
    else
    {
        Console.WriteLine("El numero invertido es: " + numero);
    }
}
else
{
    Console.WriteLine("El numero ingresado es menor a 0");
}
//numero++;
//Console.WriteLine("El numero invertido es:" + numero);
