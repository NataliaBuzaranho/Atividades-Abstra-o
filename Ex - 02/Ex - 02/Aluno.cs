namespace Ex___02
{
    public class Aluno
    {
        public int Rm { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }


        public Aluno(int rm, string nome, DateTime nascimento, string email)
        {
            Rm = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

    }
}
