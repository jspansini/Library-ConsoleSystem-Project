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
        public static void RealizarLogin(Funcionario funcionario)
        {
            bool verif = false;
            do
            {
                Console.WriteLine("Insira o login: ");
                string login = Validacao.StringV();
                if (funcionario.Login == login)
                {
                    Console.WriteLine("Digite a senha:");
                    string senha = Console.ReadLine();
                    if (funcionario.Senha == senha)
                    {
                        Console.WriteLine("Seja bem vindo!");
                        verif = true;
                    }
                    else
                    {
                        Console.WriteLine("Senha inválida, tente novamente");
                    }
                }
                else
                {
                    Console.WriteLine("Usuário incorreto! tente novamente");
                }
            } while (verif == false);
        }
        
        //TODO implementar metodo
        public static Cliente RegistrarCliente()
        {
            Console.WriteLine("Insira o nome:");
            string nome = Validacao.StringV();
            Console.WriteLine("Insira o sobrenome:");
            string sobrenome = Validacao.StringV();
            Console.WriteLine("Insira o cpf:");
            string cpf = Validacao.CPF();
            Console.WriteLine("Insira a idade:");
            int idade = Validacao.IntV();
            Console.WriteLine("Insira o endereço:");
            string endereco = Validacao.StringV();
            Console.WriteLine("Insira o email:");
            string email = Validacao.StringV();

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
                if (checkInput == false)
                    Console.WriteLine("Digite uma opção válida: ");
                else if (input > 5 && input <0)
                {
                    Console.WriteLine("Opção digitada não existe! Digite uma opção válida: ");
                    checkInput = false;
                }
            } while (!checkInput);

            return input;
        }
        //TODO Finalizar Busca cliente
        //public static Cliente BuscarCliente( List<Cliente> clientes)
        //{
        //    Cliente c ;
        //    do
        //    {
        //        Console.WriteLine("Qual o nome do cliente: ");
        //        string cliente = Validacao.StringV();
        //        foreach (Cliente n in clientes)
        //            if (n.Nome == cliente)
        //            {
        //                c = n;
        //            }

        //    } while (c == null);
        //    return c;
        //}

        //public static void LeituraInput(int input)
        //{
        //    switch (input)
        //    {
        //        case 1:
                   
        //    }
                
        //}
    }
}
