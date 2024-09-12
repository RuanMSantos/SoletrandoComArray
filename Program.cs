Console.Write("Digite uma palavra: ");
string palavraDigitada = Console.ReadLine()!.ToLower().Trim();

for (int i = 0; i < palavraDigitada.Length; i++)
{
    char caracter = palavraDigitada[i];
    Thread.Sleep(500);
    Console.Write($"{caracter}");
    Thread.Sleep(500);
    if(i < palavraDigitada.Length-1)Console.Write("-");
}