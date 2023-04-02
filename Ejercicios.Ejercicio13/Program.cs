
Console.WriteLine("Ingrese dos frases para iniciar comparación");
Console.WriteLine("Ingrese frase 1");
string frasea = Console.ReadLine();
Console.WriteLine("Ingrese frase 2");
string fraseb = Console.ReadLine();

if (frasea.Length == fraseb.Length)
{
    Console.WriteLine("Las dos frases son idénticas en longitud");
}
else
{
    Console.WriteLine("Las frases son distintas en longitud");
}
