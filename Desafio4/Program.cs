string textoOriginal = "Testando";
string textoInvertido = "";

for (int i = textoOriginal.Length - 1; i >= 0; i--)
{
    textoInvertido += textoOriginal[i];
}

Console.WriteLine(textoInvertido);  
