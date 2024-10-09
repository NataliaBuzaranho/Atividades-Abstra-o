using Ex___02;

Aluno aluno1 = new Aluno(2021, "Natalia Buzaranho", (new DateTime(2007,10,28)), "natalia.buzaranho@portalsesisp.org.br");

Console.WriteLine("O RM do aluno é: " + aluno1.Rm);
Console.WriteLine("O nome do aluno é: " + aluno1.Nome);
Console.WriteLine("O aluno nasceu em: " + aluno1.Nascimento);
Console.WriteLine("O email é: " + aluno1.Email);

Aluno aluno2 = new Aluno(1994, "Maria Luiza Pereira de Moraes", (new DateTime(2007,08,13)), "maria.moraes14@portalsesisp.org.br");

Console.WriteLine("\nO RM do aluno é: " + aluno2.Rm);
Console.WriteLine("O nome do aluno é: " + aluno2.Nome);
Console.WriteLine("A data de nascimento é: " + aluno2.Nascimento);
Console.WriteLine("O email é: " + aluno2.Email);

Aluno aluno3 = new Aluno(2782, "Bia dos Santos Fonseca", (new DateTime(2007,09,11)), "natalia.buzaranho@portalsesisp.org.br");

Console.WriteLine("\nO RM do aluno é: " + aluno3.Rm);
Console.WriteLine("O nome do aluno é: " + aluno3.Nome);
Console.WriteLine("A data de nascimento é: " + aluno3.Nascimento);
Console.WriteLine("O email é: " + aluno3.Email);


Console.ReadKey();
