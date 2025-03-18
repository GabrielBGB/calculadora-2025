string[] operacoesRealizadas = new string[100];
int contador = 0;

while (true)
{
    Console.Clear();
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("Calculadora Tabajara 2025");
    Console.WriteLine("-----------------------------------------");

    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Tabuada");
    Console.WriteLine("6 - Histórico de Operações");
    Console.WriteLine("S - Sair");
    Console.WriteLine("-----------------------------------------");

    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    if (opcao == "S")
        break;

    else if (opcao == "5")
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Tabuada");
        Console.WriteLine("-----------------------------------------");

        Console.Write("Digite o número desejado: ");
        int numeroTabuada = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{numeroTabuada} x {i} = {numeroTabuada * i}");

        Console.ReadLine();
        return;
    }

    else if (opcao == "6")
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Histórico de Operações");
        Console.WriteLine("-----------------------------------------");

        for (int i = 0; i < operacoesRealizadas.Length; i++)
        {
            if (operacoesRealizadas[i] != null)
                Console.WriteLine(operacoesRealizadas[i]);
        }

        Console.ReadLine();
        return;
    }

    Console.WriteLine("-----------------------------------------");

    Console.Write("Digite o primeiro número: ");
    decimal numero1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    decimal numero2 = Convert.ToDecimal(Console.ReadLine());

    decimal resultado = 0;

    switch (opcao)
    {
        case "1":
            resultado = numero1 + numero2;
            operacoesRealizadas[contador] = $"{numero1} + {numero2} = {resultado}";
            break;
        case "2":
            resultado = numero1 - numero2;
            operacoesRealizadas[contador] = $"{numero1} - {numero2} = {resultado}";
            break;
        case "3":
            resultado = numero1 * numero2;
            operacoesRealizadas[contador] = $"{numero1} x {numero2} = {resultado}";
            break;
        case "4":
            resultado = numero1 / numero2;
            operacoesRealizadas[contador] = $"{numero1} / {numero2} = {resultado}";
            break;
    }

    contador += 1;

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine("-----------------------------------------");

    Console.Write("Deseja continuar? (S/N): ");
    string opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "S")
        break;
}