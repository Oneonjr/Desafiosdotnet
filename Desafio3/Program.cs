decimal SP = 67836.43m, RJ= 36678.66m, MG = 29229.88m, ES = 27165.48m, outros = 19849.43m;
decimal Total= SP + RJ + MG + ES + outros;
decimal valorUnidadeOutros = outros / 23;

decimal percentualSP = (SP / Total)*100;
decimal percentualRJ = (RJ / Total)*100;
decimal percentualMG = (MG / Total)*100;
decimal percentualES = (ES / Total)*100;
decimal percentualoutros = (outros / Total)*100;

Console.WriteLine($"O valor em porcentagem de SP é de {percentualSP:N2}%");
Console.WriteLine($"O valor em porcentagem de RJ é de {percentualRJ:N2}%");   
Console.WriteLine($"O valor em porcentagem de MG é de {percentualMG:N2}%");   
Console.WriteLine($"O valor em porcentagem do ES é de {percentualES:N2}%");   
Console.WriteLine($"O valor em porcentagem dos demais estados é de {percentualoutros:N2}%");
