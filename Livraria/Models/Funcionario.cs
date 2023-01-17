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

        //TODO implementar
        public decimal CalcularComissao()
        {
            return 0;
        }
    }
}
