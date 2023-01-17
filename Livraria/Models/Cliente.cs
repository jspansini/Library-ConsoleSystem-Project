using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal class Cliente : Pessoa
    {
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}
