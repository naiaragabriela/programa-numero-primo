double numero, i;
bool ehPrimo = true;

double NumeroDigitado()
{
    Console.WriteLine("Digite um número: ");
    return double.Parse(Console.ReadLine());
}

numero = NumeroDigitado();

void ResultadoPrimo()
{
    for (i = 2; i < numero; i++)
    {
        if (numero % i == 0)
        {
            ehPrimo = !ehPrimo;
        }
    }
    if (ehPrimo && (numero != 0))
    {
        Console.WriteLine($"O número digitado {numero} é primo ");
    }
    else
    {
        Console.WriteLine($"O númeor digitado {numero} não é primo");
    }
}
ResultadoPrimo();