//Console.Clear();


// requisito 1 : Nossa calculadora deve permitir a soma de dois números
// requisito 2 : Nossa calculadora deve permitir a subtração de dois números
// requisito 3 : Nossa calculadora deve permitir a multiplicação de dois números
// requisito 4 : Nossa calculadora deve permitir a divisão de dois números 
// requisito 5 : Nossa calculadora deve permitir a execução de multiplas operações 
// requisito 6:  Nossa Calculadora deve dar a possibilidade de produzir a tabuada de um número informado
// requisito 7: Nossa Calculadora deve dar a possibilidade de visualizar o histórico de operações 


string[] historicoOperacoes = new string[100]; // Array / Vetor / arranjo
int contadorOperacoes = 0;


while (true == true)//condição
{
   // Console.clear();

    Console.WriteLine("--------------------------------------");
    Console.WriteLine("calculadora 2026");
    Console.WriteLine("---------------------------------------");

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - subtração");
    Console.WriteLine("3 - multiplicação");
    Console.WriteLine("4 - divisão");
    Console.WriteLine("5-Tabuada");
    Console.WriteLine("6-histórico de operações");
    Console.WriteLine("S - sair");


    Console.WriteLine();


    Console.Write("selecione uma opção válida: ");
    string? operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "S" || operacaoSelecionada == "s")
    {        
       return;
    }
    //Lógica da tabuada
    if(operacaoSelecionada == "5")
    {
       Console.Write("Digite o número que deseja gerar a tabuada: ");

       int numeroTabuada = Convert.ToInt32(Console.ReadLine()); 
       // para cada...
       //1. contador/iterador
       //2.enquanto a condição for verdadeira...
       //3.iteração da variavel contadora
       for (int contador = 1; contador <= 10; contador = contador + 1)
        {
            int resultadoTabuada = numeroTabuada * contador;

           string operacaoTabuada = numeroTabuada + "x"+ contador + "=" + resultadoTabuada;

           Console.WriteLine (operacaoTabuada); 
        }

        Console.ReadLine();

        continue;

    }

    else if(operacaoSelecionada == "6") // Visualizar o histórico de operações
    {
        Console.WriteLine("Histórico de operações: ");
        Console.WriteLine("--------------------------------------");



       for (int contador = 0; contador < contadorOperacoes; contador++)
        {
          Console.WriteLine(historicoOperacoes[contador]);
        } 

        Console.ReadLine();

        continue;
    }

    //Lógica das Operações de Cálculo
     
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

    string textoOperacao;

    switch (operacaoSelecionada) // operador do switch
    {
         case "1":
             resultado = primeiroNumero + segundoNumero;
             textoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
             break;
          case "2":
             resultado = primeiroNumero - segundoNumero;
                textoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
             break;
         case "3":
             resultado = primeiroNumero * segundoNumero;
                textoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
             break;
         case "4":
        if(segundoNumero == 0)
            {
                Console.WriteLine("Não é possivel fazer uma divisão por zero. tente novamente. ");
                 
                return;
            }

             resultado = primeiroNumero / segundoNumero;
             textoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
             break;
    default:
        Console.WriteLine("Selecione uma operação válida!");
        Console.ReadLine();


        continue;

    }

    if (contadorOperacoes < historicoOperacoes.Length)
    {
         historicoOperacoes[contadorOperacoes] = textoOperacao;

         contadorOperacoes = contadorOperacoes + 1;
   
    }

    Console.WriteLine("A operação do dois números resulta em: " + resultado);

    Console.ReadLine();
 
}

