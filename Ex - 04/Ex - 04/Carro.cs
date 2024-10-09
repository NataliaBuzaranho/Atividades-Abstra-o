namespace Ex___04
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }


        public Carro(string marca, string modelo, int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }
        public void Acelerar()
        {
            Console.WriteLine($" O carro da marca" + Marca + " acelerou em 2,4 segundos ");
        }
        public void Desacelerar()
        {
            Console.WriteLine($" O carro da marca" + Marca + " desacelerou na velocidade " + Velocidade + "Km");
        }
    }
}
