Console.Clear();

string palavraSecreta;
string letra;
bool verificacao;

Console.WriteLine("----------Forca---------");
Console.Write("Qual é a palavra secreta: ");

palavraSecreta  = Console.ReadLine().ToLower();

Console.Write("Qual é a letra? ");
letra = Console.ReadLine().ToLower();

verificacao = palavraSecreta.Contains(letra);
Console. WriteLine($"A letra \"{letra}\"  existe na palavra secreta => {verificacao}");

