using Ex___04;

Carro carro1 = new Carro("Nissan", "Skyline R34", 150);

Console.WriteLine("A marca do carro é: " + carro1.Marca);
Console.WriteLine("O modelo é: " + carro1.Modelo);
Console.WriteLine("E esta na velocidade: " + carro1.Velocidade);
carro1.Acelerar();
carro1.Desacelerar();

Carro carro2 = new Carro("Dodge", "Charger R/T", 328);

Console.WriteLine("\nA marca do carro é: " + carro2.Marca);
Console.WriteLine("O modelo é: " + carro2.Modelo);
Console.WriteLine("E esta na velocidade: " + carro2.Velocidade);
carro2.Acelerar();
carro2.Desacelerar();

Carro carro3 = new Carro("Honda", "S2000", 240);

Console.WriteLine("\nA marca do carro é: " + carro3.Marca);
Console.WriteLine("O modelo é: " + carro3.Modelo);
Console.WriteLine("E esta na velocidade: " + carro3.Velocidade);
carro3.Acelerar();
carro3.Desacelerar();

Console.ReadKey();