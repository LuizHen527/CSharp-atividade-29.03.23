// - Qual é seu ano de nascimento?
// - idade = Input - AnoAtual
// - semanas = idade * 52

// DateOnly anoAtual = DateOnly.FromDateTime(DateTime.Now.Year);

int anoAtual = DateTime.Now.Year;
int anoNascimento;

Console.WriteLine("Qual é seu ano de nascimento?");
anoNascimento = int.Parse(Console.ReadLine());

int idade = (anoAtual - anoNascimento);

int semanas = (idade * 52);

Console.WriteLine("Sua idade é de " + idade + " anos" + " ou " + semanas + " semanas");