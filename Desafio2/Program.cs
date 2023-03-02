using Newtonsoft.Json;

decimal maiorFaturamento = decimal.MinValue; 
decimal menorFaturamento = decimal.MaxValue;
decimal somafaturamentos = 0;
int quantidadefaturamentos = 0;
string jsonString = File.ReadAllText("faturamentoJAN.json"); //selecionando arquivo

// Convertendo o JSON em um objeto
FaturamentoMes faturamentoMes = JsonConvert.DeserializeObject<FaturamentoMes>(jsonString);

// Exibindo as informações do faturamento do mês
Console.WriteLine($"Faturamento do mês de {faturamentoMes.Mes}/{faturamentoMes.Ano}:");

//calculando a média
foreach (var faturamentoDia in faturamentoMes.Faturamento)
{   
    if (faturamentoDia.Valor != 0)
    {
        somafaturamentos += faturamentoDia.Valor;
        quantidadefaturamentos ++;
    }
}

decimal media = somafaturamentos / quantidadefaturamentos;


Console.WriteLine();
    
// Mostrando as datas e os faturmentos de todas as datas
foreach (var faturamentoDia in faturamentoMes.Faturamento)
{
    if (faturamentoDia.Valor == 0)
    {
        Console.WriteLine($"No dia {faturamentoDia.Data} não houve faturamento.");
    }
    else
    {
        Console.WriteLine($"No dia {faturamentoDia.Data} o faturamento foi de R$ {faturamentoDia.Valor:N2}.");
    }
}

// Verificando maior e menor faturamento.
foreach (var faturamentoDia in faturamentoMes.Faturamento)
{
    if (faturamentoDia.Valor != 0)
    {
        if (faturamentoDia.Valor > maiorFaturamento)
        {
            maiorFaturamento = faturamentoDia.Valor;
        }

        if (faturamentoDia.Valor < menorFaturamento)
        {
            menorFaturamento = faturamentoDia.Valor;
        }
    }
}

Console.WriteLine();
Console.WriteLine($"O valor com maior faturamento é de R$ {maiorFaturamento:N2}");
Console.WriteLine($"O valor com menor faturamento é de R$ {menorFaturamento:N2}");
Console.WriteLine($"A média do faturamento do mês é R$ {media:N2}"); 

class FaturamentoDia
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }

class FaturamentoMes
    {
        public string Mes { get; set; }
        public int Ano { get; set; }
        public FaturamentoDia[] Faturamento { get; set; }
    }