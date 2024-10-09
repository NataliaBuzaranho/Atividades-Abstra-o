using Ex___03;

Produto produto1 = new Produto(0302954, "Livro É assim que acaba", 129, 400, 170);

Console.WriteLine("O codigo do produto é: " + produto1.Codigo);
Console.WriteLine("O nome do produto é: " + produto1.Nome);
Console.WriteLine("O preço do produto é: " + produto1.Preco);
Console.WriteLine("Temos em estoque uma quantidade de: " + produto1.Estoque);
produto1.valorEstoque();

Produto produto2 = new Produto(0302037, "Livro Ordem paranormal iniciação", 129, 600, 170);

Console.WriteLine("\nO codigo do produto é: " + produto2.Codigo);
Console.WriteLine("O nome do produto é: " + produto2.Nome);
Console.WriteLine("O preço do produto é: " + produto2.Preco);
Console.WriteLine("Temos em estoque uma quantidade de: " + produto1.Estoque);
produto2.valorEstoque();

Produto produto3 = new Produto(0302097, "Livro Anne de Green Gables", 60, 300, 80);

Console.WriteLine("\nO codigo do produto é: " + produto3.Codigo);
Console.WriteLine("O nome do produto é: " + produto3.Nome);
Console.WriteLine("O preço do produto é: " + produto3.Preco);
Console.WriteLine("Temos em estoque uma quantidade de: " + produto3.Estoque);
produto2.valorEstoque();

Console.ReadKey();