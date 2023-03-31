// - Insira nota1
// - Insira nota2
// - Insira nota3
// - Insira nota4
// - Insira nota5
// - media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5

int nota1;
int nota2;
int nota3;
int nota4;
int nota5;

Console.WriteLine("Insira a primeira nota:");
nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a segunda nota:");
nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a terceira nota:");
nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a quarta nota:");
nota4 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira a quinta nota:");
nota5 = int.Parse(Console.ReadLine());

int media = ((nota1 + nota2 + nota3 + nota4 + nota5) / 5);

Console.WriteLine("Sua media é " + media);