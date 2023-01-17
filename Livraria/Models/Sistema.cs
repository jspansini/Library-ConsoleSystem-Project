using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal static class Sistema
    {
        //TODO implementar metodo
        public static bool RealizarLogin(Funcionario funcionario)
        {
            return false;
        }
        
        //TODO implementar metodo
        public static Cliente RegistrarCliente()
        {
            Console.WriteLine("Insira o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o sobrenome:");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Insira o cpf:");
            string cpf = Console.ReadLine();

            Console.WriteLine("Insira a idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o endereço:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Insira o email:");
            string email = Console.ReadLine();

            Cliente cliente = new Cliente(nome, sobrenome, cpf, idade, endereco, email);
            
            return cliente;
        }

        public static int Menu()
        {
            Console.WriteLine("(1) - Cadastrar Cliente ");
            Console.WriteLine("(2) - Cadastrar Produto ");
            Console.WriteLine("(3) - Realizar venda ");
            Console.WriteLine("(4) - Consultar estoque ");
            Console.WriteLine("(0) - Sair ");

            int input;
            bool checkInput;
            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out input);
            } while (!checkInput);

            return input;
        }

        //public static void LeituraInput(int input)
        //{
        //    switch (input)
        //    {
        //        case 1:
                   
        //    }
                
        //}
    }
}
