Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

int a = 0, b = 1, c = 1;

while (c < numero) {
    c = a + b;
    a = b;
    b = c;
}

if (c == numero) {
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
} else {
    Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
}
