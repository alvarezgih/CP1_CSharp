using System;

namespace ProjetoMercado.Model
{
    public class Cliente
    {
        private string _nome;
        private int _idade;
        private string _endereco;
        private string _telefone;
        private string _cpf;
        internal int Id;

        public string Nome
        {
            get { return _nome; }
            set { _nome = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentNullException("O nome do cliente não pode ser nulo ou vazio."); }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value >= 0 ? value : throw new ArgumentOutOfRangeException("A idade do cliente não pode ser negativa."); }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public Cliente(string nome, int idade, string endereco, string telefone, string cpf)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
            Telefone = telefone;
            CPF = cpf;
        }

        public static Cliente CriarCliente()
        {
            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine().Trim();

            ValidarNome(nome);

            Console.WriteLine("Digite a idade do cliente:");
            int idade = LerInteiro("Idade");

            Console.WriteLine("Digite o endereço do cliente:");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente:");
            string telefone = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente:");
            string cpf = Console.ReadLine();

            return new Cliente(nome, idade, endereco, telefone, cpf);
        }

        private static void ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentNullException("O nome do cliente não pode ser nulo ou vazio.");
            }
        }

        private static int LerInteiro(string mensagem)
        {
            int valor;

            while (true)
            {
                Console.WriteLine($"Digite a {mensagem} do cliente:");
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Erro: A {mensagem} do cliente deve ser um número inteiro não negativo. Por favor, tente novamente.");
                }
            }

            return valor;


        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}";
        }
    }
}