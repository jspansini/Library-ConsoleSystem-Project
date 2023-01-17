using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal class Funcionario : Pessoa
    {        
        public string Login { get; set; }
        //TODO rever
        public string Senha { get; private set; }
        public Funcionario(string nome, string sobrenome, string cpf, int idade, string login, string senha) : base(nome, sobrenome, cpf, idade)
        {
            Login = login;
            Senha = senha;  
        }

        //TODO implementar
        public decimal CalcularComissao()
        {
            return 0;
        }
    }
}
