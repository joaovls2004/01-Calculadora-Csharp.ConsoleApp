//Console.Clear();


// requisito 1 : Nossa calculadora deve permitir a soma de dois números
// requisito 2 : Nossa calculadora deve permitir a subtração de dois números
// requisito 3 : Nossa calculadora deve permitir a multiplicação de dois números
// requisito 4 : Nossa calculadora deve permitir a divisão de dois números 
// requisito 5 : Nossa calculadora deve permitir a execução de multiplas operações 

bool deveContinuar = true;//atribuição

while (deveContinuar == true)//condição
{
   // Console.clear();

    Console.WriteLine("--------------------------------------");
    Console.WriteLine("calculadora 2026");
    Console.WriteLine("---------------------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicaçãp");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("s - sair");

    Console.WriteLine();


    Console.Write("selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "s")
    {
       deveContinuar = false;   

       continue;
    }

    Console.Write("digite o primeiro numero: ");
    string? strPrimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo número: ");
    string? strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi:" + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi:" + strSegundoNumero );

    Console.WriteLine();

    bool primeiroNumerovazio = string.IsNullOrEmpty(strPrimeiroNumero);
    bool segundoNumerovazio = string.IsNullOrEmpty(strSegundoNumero);

     
    if (primeiroNumerovazio == true || segundoNumerovazio == true)
    {
       Console.WriteLine("Digite um número válido!");
       Console.ReadLine();

       continue;

    }

    
    decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
    decimal segundoNumero =  Convert.ToDecimal(strSegundoNumero);

    decimal resultado ;
    switch (operacaoSelecionada) // operador do switch
    {
         case "1":
             resultado = primeiroNumero + segundoNumero;
             break;
          case "2":
             resultado = primeiroNumero - segundoNumero;
             break;
         case "3":
             resultado = primeiroNumero * segundoNumero;
             break;
         case "4":
        if(segundoNumero == 0)
            {
                Console.WriteLine("Não é possivel fazer uma divisão por zero. tente novamente. ");
                 
                return;
            }

             resultado = primeiroNumero / segundoNumero;
             break;
    default:
        Console.WriteLine("Selecione uma operação válida!");
        Console.ReadLine();


        continue;

    }

    Console.WriteLine("A operação do dois números resulta em: " + resultado);

    Console.ReadLine();
 
}

