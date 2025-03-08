Console.WriteLine("Bem Vindo(a) ao Somador: ");string resp="n";

do
{
    Console.Write("Digite um numero: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite outro numero: ");
    double num2= double.Parse(Console.ReadLine());

    double resultado = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {resultado}");
     
    Console.WriteLine("Deseja rodar o progama novamente? (s/n)");
    resp = Console.ReadLine();
} while (resp == "s");

Console.WriteLine("Prossione qualquer tecla para continuar...");
Console.ReadKey();


