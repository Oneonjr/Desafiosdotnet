using Newtonsoft.Json;

// Problema 1

// Console.Write("Digite um número: ");
//         int numero = int.Parse(Console.ReadLine());

//         int a = 0, b = 1, c = 1;

//         while (c < numero) {
//             c = a + b;
//             a = b;
//             b = c;
//         }

//         if (c == numero) {
//             Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
//         } else {
//             Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
//         }


//      Problema 2


// Lê o arquivo JSON a partir do caminho especificado
            // string jsonFilePath = "C";

            decimal media = 20117 ;
            string jsonString = File.ReadAllText("faturamentoJAN.json");

            // Converte o JSON em um objeto C# usando a biblioteca Newtonsoft.Json
            FaturamentoMes faturamentoMes = JsonConvert.DeserializeObject<FaturamentoMes>(jsonString);

            // Exibe as informações do faturamento do mês
            Console.WriteLine($"Faturamento do mês de {faturamentoMes.Mes}/{faturamentoMes.Ano}:");
            Console.WriteLine($"A média do faturamento é R$ {media:N2}");
            Console.WriteLine();

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

            Console.ReadLine();
        
    

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
