using Ex___01;

Livro livro1 = new Livro("O Príncipe Cruel", "Holly Black", "Grupo Editorial Record", 2018);

Console.WriteLine("O titulo do livro é: " + livro1.Titulo);
Console.WriteLine("A autora do livro é: " + livro1.Autor);
Console.WriteLine("A editora do livro é: " + livro1.Editora);
Console.WriteLine("O ano de lançamento é: " + livro1.Ano);

Livro livro2 = new Livro("Lore Olimpus", "Rachek Smyth", "Suma", 2021);

Console.WriteLine("\nO titulo do livro é: " + livro2.Titulo);
Console.WriteLine("A autora do livro é: " + livro2.Autor);
Console.WriteLine("A editora do livro é: " + livro2.Editora);
Console.WriteLine("O ano de lançamento é: " + livro2.Ano);

Livro livro3 = new Livro("Mordida", "Sarah Andersen", "Seguinte", 2021);

Console.WriteLine("\nO titulo do livro é: " + livro3.Titulo);
Console.WriteLine("A autora do livro é: " + livro3.Autor);
Console.WriteLine("A editora do livro é: " + livro3.Editora);
Console.WriteLine("O ano de lançamento é: " + livro3.Ano);
Console.ReadKey();
